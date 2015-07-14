﻿using System;
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

        private ModAddress modAddress;

        public static int size_x = 380;
        public static int size_y = 96;

        public ModAddressControl(ModAddress modAddress, bool minimal)
        {
            InitializeComponent();
            this.modAddress = modAddress;

            tb_min.Text = modAddress.min.ToString();
            tb_max.Text = modAddress.max.ToString();
            lbl_value.Text = modAddress.value.ToString();

            AdjustScrollbar();
            UpdateBackgroundColor();

            if (minimal)
            {
                btn_automate.Visible = false;
                btn_tie.Visible = false;
                this.BorderStyle = BorderStyle.None;
                cb_locked.Checked = true;
            }
        }

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

        private void ModAddressControl_Load(object sender, EventArgs e)
        {
            tb_max.Text = Convert.ToString(modAddress.max);
            tb_min.Text = Convert.ToString(modAddress.min);
            scrollbar.Minimum = 0;
            scrollbar.Maximum = 109;

            lbl_address.Text = modAddress.address.ToString("X");
            lbl_name.Text = modAddress.name;
            lbl_value.Text = modAddress.value.ToString();

            ChangeType(modAddress.type);
        }

        private void scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            modAddress.value = modAddress.min + ((double)scrollbar.Value / (double)100) * (modAddress.max - modAddress.min);
            lbl_value.Text = modAddress.value.ToString();
        }

        public ModAddress getModAddress() { return modAddress; }

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
                catch
                {
                    //do nothing
                }
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
                catch
                {
                    //do nothing
                }
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
