using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace ProcessModify
{
    public partial class Form1 : Form
    {
        Process attachedProcess;
        MemoryModifier memoryModifier;
        List<ModAddressControl> modAddressControls;

        bool attachedToProcess;
        bool writingToProcess;
        bool displayTrueValues;
        bool varConversionsActive;

        public Form1()
        {
            InitializeComponent();
            modAddressControls = new List<ModAddressControl>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void menu_attach_Click(object sender, EventArgs e)
        {
            AttachToProcess();
        }

        private void AttachToProcess()
        {
            AttachForm attachForm = new AttachForm();
            attachForm.ShowDialog();
            if (attachForm.DialogResult == DialogResult.OK)
            {
                attachedProcess = attachForm.selectedProcess;
                lbl_process.Text = attachedProcess.ProcessName;
                lbl_pid.Text = attachedProcess.Id.ToString();
                lbl_attached_status.Text = "Attached";
                lbl_attached_status.ForeColor = Color.Green;
                btn_toggle_writing_to_process.Enabled = true;
                attachedToProcess = true;
                writingToProcess = false;
                displayTrueValues = true;
                varConversionsActive = true;
                btn_open_hex.Enabled = true;
                memoryModifier = new MemoryModifier(attachedProcess);
                updateTimer.Start();
            }
        }

        private void btn_open_hex_Click(object sender, EventArgs e)
        {
            HexEditForm hexEditForm;
            if (lb_mod_addresses.SelectedIndex != -1)
            {
                hexEditForm = new HexEditForm(modAddressControls[lb_mod_addresses.SelectedIndex].getModAddress().address, memoryModifier,this);
            }
            else
            {
                hexEditForm = new HexEditForm(0x00000, memoryModifier,this);
            }
            hexEditForm.Show();
        }

        private void ToggleWritingToProcess()
        {
            if (writingToProcess)
            {
                writingToProcess = false;
                btn_toggle_writing_to_process.Image = global::ProcessModify.Properties.Resources.disconnected;
            }
            else
            {
                writingToProcess = true;
                btn_toggle_writing_to_process.Image = global::ProcessModify.Properties.Resources.connected;
            }
        }

        private void AddModAddress(ModAddress m)
        {
            ModAddressControl modAddressControl = new ModAddressControl(m, false);
             modAddressControls.Add(modAddressControl);
             int locationX = 0;
             int locationY = ModAddressControl.size_y * (modAddressControls.Count - 1) + panel_mod_addresses.AutoScrollPosition.Y;

            modAddressControl.Location = new Point(locationX, locationY );        
            panel_mod_addresses.Controls.Add(modAddressControl);
            lb_mod_addresses.Items.Add(m.name);
        }

        private void RemoveModAddress(int index)
        {
            if (index >= 0)
            {
                for (int i = index + 1; i < modAddressControls.Count; i++)
                {
                    modAddressControls[i].Location = new Point(modAddressControls[i].Location.X, modAddressControls[i].Location.Y - ModAddressControl.size_y);
                }
                panel_mod_addresses.Controls.Remove(modAddressControls[index]);
                modAddressControls.Remove(modAddressControls[index]);
                lb_mod_addresses.Items.RemoveAt(index);
                try
                {
                    lb_mod_addresses.SelectedIndex = index;
                }
                catch //the last item was removed
                {
                    lb_mod_addresses.SelectedIndex = index - 1;
                }
            }
        }

        private void btn_add_address_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 address = int.Parse(tb_add_address.Text, System.Globalization.NumberStyles.HexNumber);
                int type = comboBox1.SelectedIndex;
                ModAddress m = new ModAddress(address, type, tb_add_address_name.Text);
                AddModAddress(m);
            }
            catch
            {
                MessageBox.Show("invalid memory address");
            }
        }

        private void btn_remove_address_Click(object sender, EventArgs e)
        {
            RemoveModAddress(lb_mod_addresses.SelectedIndex);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (displayTrueValues)
            {
                foreach (ModAddressControl m in modAddressControls)
                {
                    //update label showing true value from process
                    m.UpdateActualValueLabel(memoryModifier);
                }
            }

            if (writingToProcess)
            {
                foreach (ModAddressControl m in modAddressControls)
                {
                    if (m.getIsActive())
                    {
                        ModAddress modAddress = m.getModAddress();

                        if (modAddress.type == (int)ModAddress.dataTypes.Byte)
                            memoryModifier.WriteToAddress(modAddress.address, (byte)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.UInt16))
                            memoryModifier.WriteToAddress(modAddress.address, (UInt16)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.Int16))
                            memoryModifier.WriteToAddress(modAddress.address, (Int16)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.UInt32))
                            memoryModifier.WriteToAddress(modAddress.address, (UInt32)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.Int32))
                            memoryModifier.WriteToAddress(modAddress.address, (Int32)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.UInt64))
                            memoryModifier.WriteToAddress(modAddress.address, (UInt64)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.Int64))
                            memoryModifier.WriteToAddress(modAddress.address, (Int64)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.Float))
                            memoryModifier.WriteToAddress(modAddress.address, (float)(modAddress.value));
                        else if ((modAddress.type == (int)ModAddress.dataTypes.Double))
                            memoryModifier.WriteToAddress(modAddress.address, (double)(modAddress.value));
                    }
                }
            }

            if (varConversionsActive && lb_mod_addresses.SelectedIndex != -1)
            {
                UpdateValueConversionLabels(modAddressControls[lb_mod_addresses.SelectedIndex].getModAddress().address);
            }
        }

        private void UpdateValueConversionLabels(Int32 address)
        {
            lbl_var_as_byte.Text = Convert.ToString(memoryModifier.ReadFromAddress(address, 1)[0]);

            ushort us = BitConverter.ToUInt16(memoryModifier.ReadFromAddress(address, 2), 0);
            lbl_var_as_uint16.Text = us.ToString();

            short s = BitConverter.ToInt16(memoryModifier.ReadFromAddress(address, 2), 0);
            lbl_var_as_int16.Text = s.ToString();

            uint ui = BitConverter.ToUInt32(memoryModifier.ReadFromAddress(address, 4), 0);
            lbl_var_as_uint32.Text = ui.ToString();

            int i = BitConverter.ToInt32(memoryModifier.ReadFromAddress(address, 4), 0);
            lbl_var_as_int32.Text = i.ToString();

            UInt64 ul = BitConverter.ToUInt64(memoryModifier.ReadFromAddress(address, 8), 0);
            lbl_var_as_int64.Text = ul.ToString();

            Int64 l = BitConverter.ToInt64(memoryModifier.ReadFromAddress(address, 8), 0);
            lbl_var_as_uint64.Text = l.ToString();

            float f = BitConverter.ToSingle(memoryModifier.ReadFromAddress(address, 4), 0);
            lbl_var_as_float.Text = f.ToString();

            double d = BitConverter.ToDouble(memoryModifier.ReadFromAddress(address, 8), 0);
            lbl_var_as_double.Text = d.ToString();
        }

        private void lb_mod_addresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_mod_addresses.SelectedIndex != -1)
            {
                panel_mod_addresses.AutoScrollPosition = new Point(0, ModAddressControl.size_y * lb_mod_addresses.SelectedIndex);
                lbl_var_name.Text = lb_mod_addresses.SelectedItem.ToString();
                lbl_var_address.Text = modAddressControls[lb_mod_addresses.SelectedIndex].getModAddress().address.ToString("X8");
            }
        }

        //smooths panel scrolling and removes flashing
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panel_mod_addresses_Scroll(object sender, ScrollEventArgs e) 
        {
            int redraw = 0xB;
            Control control = sender as Control;
            if (control != null)
            {
                if (e.Type == ScrollEventType.ThumbTrack)
                {
                    SendMessage(control.Handle, redraw, 1, 0);
                    control.Refresh();
                    SendMessage(control.Handle, redraw, 0, 0);
                }
                else
                {
                    SendMessage(control.Handle, redraw, 1, 0);
                    control.Invalidate();
                }
            }
        }

        private void lbl_attached_status_DoubleClick(object sender, EventArgs e)
        {
            if (!attachedToProcess)
                AttachToProcess();
        }

        private void btn_toggle_writing_to_process_Click(object sender, EventArgs e)
        {
            ToggleWritingToProcess();

            //update label
            if (writingToProcess)
            {
                lbl_writing_to_process.Text = "Writing to process";
                lbl_writing_to_process.ForeColor = Color.Green;
            }
            else
            {
                lbl_writing_to_process.Text = "Not writing to process";
                lbl_writing_to_process.ForeColor = Color.Red;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.DefaultExt = ".xml";
            sfd.Filter = "XML Files (*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WriteToFile(sfd.FileName);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.DefaultExt = ".xml";
            ofd.Filter = "XML Files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadFile(ofd.FileName);
                lbl_file_name.Text = ofd.SafeFileName;
                lbl_file_name.ForeColor = Color.Black;
            }
        }

        private void LoadFile(string path)
        {
            try
            {
                XDocument xml = XDocument.Load(path);
                int ununused = xml.Descendants("Addresses").Elements().Count();
                foreach (XElement setting in xml.Descendants("Address"))
                {
                    Int32 address = Convert.ToInt32(setting.Element("address").Value);
                    string name = setting.Element("name").Value;
                    double min = Convert.ToDouble(setting.Element("min").Value);
                    double max = Convert.ToDouble(setting.Element("max").Value);
                    double value = Convert.ToDouble(setting.Element("value").Value);
                    int type = Convert.ToInt32(setting.Element("type").Value);
                    ModAddress modAddress = new ModAddress(address, name, min, max, value, type);
                    AddModAddress(modAddress);
                }
            }
            catch
            {
                MessageBox.Show("Load Settings Error");
            }
        }

        private void WriteToFile(string path)
        {
            //saves address list with attributes
            XElement xmlDocument = new XElement("Addresses");
            foreach (ModAddressControl m in modAddressControls)
            {
                XElement xml_ma = new XElement("Address",
                new XElement("address", m.getModAddress().address),
                new XElement("name", m.getModAddress().name),
                new XElement("min", m.getModAddress().min),
                new XElement("max", m.getModAddress().max),
                new XElement("value", m.getModAddress().value),
                new XElement("type", m.getModAddress().type)
                );
                xmlDocument.Add(xml_ma);
            }
            xmlDocument.Save(path);
        }

        private void menu_quit_Click(object sender, EventArgs e) { Application.Exit();  }
        private void menu_save_Click(object sender, EventArgs e) { btn_save.PerformClick(); }
        private void menu_load_Click(object sender, EventArgs e) { btn_load.PerformClick(); }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   
    }
}
