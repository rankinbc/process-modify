using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessModify
{
    public partial class ModAddressControl : UserControl
    {
        public static int sizeX = 380;
        public static int sizeY = 80; 
        public BigCheckBox cb_locked;

        private ModAddress modAddress;
       
        public ModAddressControl(ModAddress modAddress, bool minimal)
        {
            InitializeComponent();
            cb_locked = new BigCheckBox();
            this.cb_locked.CheckedChanged += cb_locked_CheckedChanged;
            this.Controls.Add(cb_locked);
            this.modAddress = modAddress;

            if (minimal)
            {
                btn_automate.Visible = false;
                btn_tie.Visible = false;
                this.BorderStyle = BorderStyle.None;
                cb_locked.Checked = true;
                lbl_address.Font = new Font(lbl_name.Font, FontStyle.Bold);
            }
        }

        private void ModAddressControl_Load(object sender, EventArgs e)
        {
            tb_max.Text = modAddress.max.ToString();
            tb_min.Text = modAddress.min.ToString();
            lbl_value.Text = modAddress.value.ToString();
            lbl_address.Text = modAddress.address.ToString("X8");
            lbl_name.Text = modAddress.name;
            lbl_value.Text = modAddress.value.ToString();
            scrollbar.Minimum = 0;
            scrollbar.Maximum = 109;

            AdjustScrollbar();
            UpdateBackgroundColor();
            ChangeType(modAddress.type);
        }

        public ModAddress getModAddress() { return modAddress; }

        private void UpdateBackgroundColor()
        {
            if (getIsActive())
                this.BackColor = Color.FromArgb(224, 224, 224);
            else
                this.BackColor = Color.Transparent;
        }

        public void ChangeType(int type)
        {
            lbl_type.Text = ModAddress.dataTypeStrings[type];
        }

        private void scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            modAddress.value = modAddress.min + ((double)scrollbar.Value / (double)100) * (modAddress.max - modAddress.min);
            lbl_value.Text = modAddress.value.ToString();
        }

        private void tb_max_TextChanged(object sender, EventArgs e)
        {
            try
            {
                modAddress.max = Convert.ToInt32(tb_max.Text);
            }
            catch
            {
                try
                {
                    modAddress.min = Convert.ToDouble(tb_min.Text);
                }
                catch  { }
            }
        }

        private void tb_min_TextChanged(object sender, EventArgs e)
        {
            try
            {
                modAddress.min = Convert.ToInt32(tb_min.Text);
            }
            catch
            {
                try
                {
                    modAddress.min = Convert.ToDouble(tb_min.Text);
                }
                catch { }
            }
        }

        private void AdjustScrollbar()
        {
            double range = modAddress.max - modAddress.min;
            double dist = modAddress.min + modAddress.value;
            scrollbar.Value = (int)(100.0 * (Math.Abs(dist) / range));
        }

        public bool getIsActive() { return cb_locked.Checked; }
        public void setIsActive(bool a) { cb_locked.Checked = a; }

        private void cb_locked_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBackgroundColor();
        }

        public void UpdateActualValueLabel(MemoryModifier m)
        {
            int bytesToRead = -1;
            switch (modAddress.type)
            {
                case (int)ModAddress.dataTypes.Byte:
                    {
                        bytesToRead = 1;
                        byte av = m.ReadFromAddress(modAddress.address, bytesToRead)[0];
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.UInt16:
                    {
                        bytesToRead = 2;
                        UInt16 av = BitConverter.ToUInt16(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.Int16:
                    {
                        bytesToRead = 2;
                        Int16 av = BitConverter.ToInt16(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.UInt32:
                    {
                        bytesToRead = 4;
                        UInt32 av = BitConverter.ToUInt32(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.Int32:
                    {
                        bytesToRead = 4;
                        Int32 av = BitConverter.ToInt32(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.UInt64:
                    {
                        bytesToRead = 8;
                        UInt64 av = BitConverter.ToUInt64(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.Int64:
                    {
                        bytesToRead = 8;
                        Int64 av = BitConverter.ToInt64(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.Float:
                    {
                        bytesToRead = 4;
                        float av = BitConverter.ToSingle(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                case (int)ModAddress.dataTypes.Double:
                    {
                        bytesToRead = 8;
                        double av = BitConverter.ToDouble(m.ReadFromAddress(modAddress.address, bytesToRead), 0);
                        lbl_actual_value.Text = av.ToString();
                        break;
                    }
                default: bytesToRead = -1; break;
            }
        }

        private void btn_automate_Click(object sender, EventArgs e)
        {
            //Todo: 
            //Add variable automation: control a variables value based on elapsed time
        }

        private void btn_tie_Click(object sender, EventArgs e)
        {
            //Todo: 
            //Add variable tying: have a variable's value be derived from a specified equation including another variables value
        }
    }
}
