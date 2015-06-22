using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessModify
{
    public partial class HexEditForm : Form
    {
        Int32 startAddress;
        Int32 selectedAddress;
        MemoryModifier memoryModifier;
        ModAddress modAddress;
        ModAddressControl modAddressControl;

        int nRows = 20;
        HexRow[] hexRows;

        public HexEditForm(Int32 initAddress, MemoryModifier m)
        {
            InitializeComponent();
            memoryModifier = m;
            selectedAddress = initAddress;
            initForm(initAddress, true);
        }

        private void HexEditForm_Load(object sender, EventArgs e)
        {
            cb_type.SelectedIndex = 0;
        }

        public void initForm(Int32 initAddress, bool first)
        {
            int type;
            if (first)
            {
                type = (int)ModAddress.Types.Byte;
            }
            else
            {
                type = modAddress.type;
            }
            startAddress = trimAddress(initAddress);
            modAddress = new ModAddress(selectedAddress, type, "Selected");

            if (first)
                loadFormControls();
            else
                editFormControls();
        }

        void clearHexRows()
        {
            foreach (HexRow hr in hexRows)
            {
                this.Controls.Remove(hr);
            }
        }

        private void editFormControls()
        {
            int i = 0;
            for (; i < nRows; i++)
            {
                hexRows[i].reset(startAddress + (16 * i));
            }
            timer1.Start();
        }

        public void changeSelectedAddress(Int32 addr)
        {
            selectedAddress = addr;
            modAddress.address = addr;
            bool active = modAddressControl.getIsActive();
            Controls.Remove(modAddressControl);
            modAddressControl = new ModAddressControl(modAddress, true);
            modAddressControl.Location = new Point(50, 50 + 22 * (nRows + 1));
            lbl_selected_address.Text = selectedAddress.ToString("X");
            modAddressControl.ChangeType(cb_type.SelectedIndex);
            modAddressControl.setIsActive(active);
            this.Controls.Add(modAddressControl);
        }

        private void loadFormControls()
        {
            hexRows = new HexRow[nRows];
            int hexRowsStartY = 50;
            int i = 0;
            for (; i < nRows; i++)
            {
                hexRows[i] = new HexRow(startAddress + (16 * i), this);
                hexRows[i].Location = new Point(0, hexRowsStartY + (22 * i));
                this.Controls.Add(hexRows[i]);
            }

            modAddressControl = new ModAddressControl(modAddress, true);
            modAddressControl.Location = new Point(50, 50 + 22 * (i + 1));
            this.Controls.Add(modAddressControl);
            lbl_selected_address.Text = selectedAddress.ToString("X8");
            timer1.Start();
        }

        Int32 trimAddress(Int32 a)
        {
            if (a.ToString("X").EndsWith("F")) { return a - 15; }
            else if (a.ToString("X").EndsWith("E")) { return a - 14; }
            else if (a.ToString("X").EndsWith("D")) { return a - 13; }
            else if (a.ToString("X").EndsWith("C")) { return a - 12; }
            else if (a.ToString("X").EndsWith("B")) { return a - 11; }
            else if (a.ToString("X").EndsWith("A")) { return a - 10; }
            else if (a.ToString("X").EndsWith("9")) { return a - 9; }
            else if (a.ToString("X").EndsWith("8")) { return a - 8; }
            else if (a.ToString("X").EndsWith("7")) { return a - 7; }
            else if (a.ToString("X").EndsWith("6")) { return a - 6; }
            else if (a.ToString("X").EndsWith("5")) { return a - 5; }
            else if (a.ToString("X").EndsWith("4")) { return a - 4; }
            else if (a.ToString("X").EndsWith("3")) { return a - 3; }
            else if (a.ToString("X").EndsWith("2")) { return a - 2; }
            else if (a.ToString("X").EndsWith("1")) { return a - 1; }
            else if (a.ToString("X").EndsWith("0")) { return a - 0; }
            else return -1;             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            modAddressControl.Update();
            if (modAddressControl.getIsActive())
            {
                if (modAddress.type == (int)ModAddress.Types.Byte)
                {
                    memoryModifier.WriteToAddress(modAddress.address, (byte)((int)modAddress.value));
                }
                else if ((modAddress.type == (int)ModAddress.Types.Float))
                {
                    memoryModifier.WriteToAddress(modAddress.address, (float)(modAddress.value));
                }
                modAddressControl.UpdateActualValueLabel(memoryModifier);
            }
            foreach (HexRow hr in hexRows)
            {
                hr.updateTextBoxes(memoryModifier.ReadFromAddress(hr.startAddress, 16));
            }
        }

        private void btn_jump_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                initForm(int.Parse(tb_jump_address.Text, System.Globalization.NumberStyles.HexNumber), false);
            }
            catch { }
        }

        private void btn_scroll_up_Click(object sender, EventArgs e)
        {
            initForm(startAddress - 16, false);
        }

        private void btn_scroll_down_Click(object sender, EventArgs e)
        {
            initForm(startAddress + 16, false);
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateModAddressType();
        }

        void updateModAddressType()
        {
            if (cb_type.SelectedIndex == 0)
                modAddress.type = (int)ModAddress.Types.Byte;
            else if (cb_type.SelectedIndex == 1)
                modAddress.type = (int)ModAddress.Types.Short;
            else if (cb_type.SelectedIndex == 2)
                modAddress.type = (int)ModAddress.Types.Float;
            else if (cb_type.SelectedIndex == 3)
                modAddress.type = (int)ModAddress.Types.Double;

            modAddressControl.ChangeType(modAddress.type);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.LargeDecrement || e.Type == ScrollEventType.SmallDecrement)
            {
                initForm(startAddress - 16, false);
            }
            else if (e.Type == ScrollEventType.LargeIncrement || e.Type == ScrollEventType.SmallIncrement)
            {
                initForm(startAddress + 16, false);
            }
        }
    }
}
