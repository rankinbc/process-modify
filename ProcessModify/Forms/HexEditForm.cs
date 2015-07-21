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
        Int32  startAddress;
        Int32  selectedAddress;
        MemoryModifier memoryModifier;
        ModAddress modAddress;
        ModAddressControl modAddressControl;
        List<TextBox> highlightedTextBoxes;

        int nRows = 20;
        HexRow[] hexRows;
        MainForm form1Pointer;

        public HexEditForm(Int32 initAddress, MemoryModifier m, MainForm formPtr)
        {
            InitializeComponent();
            form1Pointer = formPtr;
            memoryModifier = m;
            selectedAddress = initAddress;
            highlightedTextBoxes = new List<TextBox>();
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
                type = (int)ModAddress.dataTypes.Byte;
            }
            else
            {
                type = modAddress.type;
            }
            startAddress = trimAddress(initAddress);
            modAddress = new ModAddress(selectedAddress, type, "");

            if (first)
                loadFormControls();
            else
                editFormControls();
        }

        private void loadFormControls()
        {
            hexRows = new HexRow[nRows];
            int i = 0;
            for (; i < nRows; i++)
            {
                hexRows[i] = new HexRow(startAddress + (16 * i), this);
                hexRows[i].Location = new Point(0, (HexRow.sizeY * i));
                hex_panel.Controls.Add(hexRows[i]);
            }

            modAddressControl = new ModAddressControl(modAddress, true);
            modAddressControl.Location = new Point(0, 0);
            mod_panel.Controls.Add(modAddressControl);
            modAddressControl.lbl_name.Text = selectedAddress.ToString("X8");

            timer1.Start();
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

        public void changeSelectedAddress(Int32  addr)
        {
           //select and remove
            selectedAddress = addr;
            modAddress.address = addr;
            bool active = modAddressControl.getIsActive();
            mod_panel.Controls.Remove(modAddressControl);

            //create new control
            modAddressControl = new ModAddressControl(modAddress, true);
            modAddressControl.Location = new Point(0, 0); 
            modAddressControl.lbl_name.Text = selectedAddress.ToString("X");
            modAddressControl.ChangeType(cb_type.SelectedIndex);
            modAddressControl.setIsActive(active);
            mod_panel.Controls.Add(modAddressControl);

            //highlight selected bytes
            if (tab_control.SelectedIndex == 0) //set value
                highlightSelectedAddress(addr, ModAddress.dataTypeSizes[modAddress.type]);
            else if (tab_control.SelectedIndex == 1) //randomize
                highlightSelectedAddress(addr, Convert.ToInt32(tb_randomize_amount.Text));
        }

        private void highlightSelectedAddress(Int32 address, int bytes) //rewrite this
        {
                //unhighlight currently selected textboxes and clear list
                highlightSelectedTextBoxes(false);
                highlightedTextBoxes.Clear();

            if (startAddress + (hexRows.Length * 16) > selectedAddress &&
                selectedAddress + bytes > startAddress) //if a selected byte is visible on the screen
            {

                //select hexRow containing selected address
                HexRow hexRow = null;
                int hexRowStartIndex = -1;
                int hexRowStartAddress = -1;
                for (int i = 0; i < hexRows.Length; i++)
                {
                    hexRowStartAddress = trimAddress(selectedAddress);
                    if (hexRowStartAddress == hexRows[i].startAddress)
                    {
                        hexRowStartIndex = i;
                        hexRow = hexRows[i];
                        break;
                    }
                }

                //highlight selected bytes
                int byteOffset = selectedAddress - hexRowStartAddress;
                int totalHexRows = ((bytes + byteOffset) / 16) + 1;
                int totalLeftToHighlight = bytes;

                for (int j = 0; j < totalHexRows; j++) //for each row
                {
                    if (hexRowStartIndex + j > hexRows.Length - 1) //the following bytes are off screen
                    {
                        break;
                    }
                    else if (hexRowStartIndex + j < 0) //selected address is above the screen
                    {
                        //subtract bytes that are not visible and reset offset and start index to 0 (first visible textbox)
                        int firstVisibleAddress = hexRows[0].startAddress;
                        int differenceInBytes = firstVisibleAddress - selectedAddress;
                        bytes -= differenceInBytes;
                        byteOffset = 0;
                        hexRowStartIndex = 0;

                        totalHexRows--;
                    }

                    for (int i = byteOffset; i < bytes + byteOffset && totalLeftToHighlight > 0; i++) //for each byte
                    {
                        if (i <= 15)
                        {
                            TextBox tb = hexRows[hexRowStartIndex + j].getByteTextBox(i);
                            highlightTextBox(tb, true);
                            highlightedTextBoxes.Add(tb);
                            totalLeftToHighlight--;

                        }
                        else
                        {
                            //start on new row
                            byteOffset = 0;
                        }
                    }
                }
            }
        }

        public void highlightSelectedTextBoxes(bool highlighted)
        {
            foreach (TextBox tb in highlightedTextBoxes)
            {
                highlightTextBox(tb, highlighted);
            }
        }
        public void highlightTextBox(TextBox tb, bool highlighted)
        {
            if (highlighted)
            {
                tb.BackColor = Color.Black;
                tb.ForeColor = Color.Gainsboro;
            }
            else
            {
                tb.BackColor = Color.Gainsboro;
                tb.ForeColor = Color.Black;
            }
        }
       

        Int32  trimAddress(Int32  a)
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
                switch (modAddress.type)
                {
                    case (int)ModAddress.dataTypes.Byte: memoryModifier.WriteToAddress(modAddress.address, (byte)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.UInt16: memoryModifier.WriteToAddress(modAddress.address, (UInt16)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.Int16: memoryModifier.WriteToAddress(modAddress.address, (Int16)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.UInt32: memoryModifier.WriteToAddress(modAddress.address, (UInt32)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.Int32: memoryModifier.WriteToAddress(modAddress.address, (Int32)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.UInt64: memoryModifier.WriteToAddress(modAddress.address, (UInt64)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.Int64: memoryModifier.WriteToAddress(modAddress.address, (Int64)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.Float: memoryModifier.WriteToAddress(modAddress.address, (float)(modAddress.value)); break;
                    case (int)ModAddress.dataTypes.Double: memoryModifier.WriteToAddress(modAddress.address, (double)(modAddress.value)); break;
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

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateModAddressType();
            highlightSelectedAddress(modAddress.address,ModAddress.dataTypeSizes[modAddress.type]);
        }

        void updateModAddressType()
        {
            modAddress.type = cb_type.SelectedIndex;
            modAddressControl.ChangeType(modAddress.type);
        }

        private void btn_add_address_Click(object sender, EventArgs e)
        {
            form1Pointer.tb_add_address.Text = selectedAddress.ToString("X");
            form1Pointer.comboBox1.SelectedIndex = cb_type.SelectedIndex;
            form1Pointer.tb_add_address_name.Focus();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.LargeDecrement || e.Type == ScrollEventType.SmallDecrement)
                  ScrollHexWindow(-16);
            else if (e.Type == ScrollEventType.LargeIncrement || e.Type == ScrollEventType.SmallIncrement)
                ScrollHexWindow(16);
        }

        private void page_down_Click(object sender, EventArgs e) {  ScrollHexWindow((16 * hexRows.Length));   }
        private void page_up_Click(object sender, EventArgs e)   { ScrollHexWindow((16 * -hexRows.Length));  }

        private void ScrollHexWindow(int dRows)
        {
            initForm(startAddress + dRows, false);
            highlightSelectedAddress(startAddress + dRows, getAmountOfSelectedBytes());
        }

        private int getAmountOfSelectedBytes()
        {
            if (tab_control.SelectedIndex == 0)
            {
                return ModAddress.dataTypeSizes[modAddress.type];
            }
            else if (tab_control.SelectedIndex == 1)
            {
                try
                {
                    return Convert.ToInt32(tb_randomize_amount.Text);
                }
                catch { }
            }
            return -1;
        }
  
     

        private void btn_randomize_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int totalBytes = Convert.ToInt32(tb_randomize_amount.Text);
                int byteMin = Convert.ToInt32(tb_random_min.Text);
                int byteMax = Convert.ToInt32(tb_random_max.Text);

                for (int i = 0; i < totalBytes; i++)
                {
                    memoryModifier.WriteToAddress(modAddress.address + i, (byte)(random.Next(byteMin, byteMax + 1)));
                }
                highlightSelectedAddress(modAddress.address, totalBytes);
            }
            catch
            {
                MessageBox.Show("Invalid Input 2");
            }
        }

        private void tb_randomize_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total_bytes = Convert.ToInt32(tb_randomize_amount.Text);
                highlightSelectedAddress(modAddress.address, total_bytes);
            }
            catch
            {
                MessageBox.Show("Invalid Input 1");
            }
        }

        private void tab_control_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_control.SelectedIndex == 1)
            {
                modAddressControl.cb_locked.Checked = false;
            }
        }

        private void btn_jump_to_next_nonzero_Click(object sender, EventArgs e)
        {
            int currentByteIndex = selectedAddress;
            byte currentByteValue = memoryModifier.ReadFromAddress(currentByteIndex,1)[0];
            while (currentByteValue == 0)
            {
                currentByteIndex++;
                currentByteValue = memoryModifier.ReadFromAddress(currentByteIndex,1)[0];
            }

            if (currentByteValue != 0)
            {
                selectedAddress = currentByteIndex;
                initForm(selectedAddress, false);
                highlightSelectedAddress(selectedAddress, 1);
            }
        }

        private void btn_jump_by_Click(object sender, EventArgs e)
        {
            int jumpToIndex = startAddress + Convert.ToInt32(tb_jump_by.Text);
            selectedAddress = jumpToIndex;
            initForm(selectedAddress, false);
            highlightSelectedAddress(selectedAddress, 1);
        }
    }
}
