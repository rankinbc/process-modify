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
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private const int WM_SETREDRAW = 0xB;

        
        Process currentProcess;
        MemoryModifier memoryModifier;
        List<ModAddress> modAddresses;
        List<ModAddressControl> modAddressControls;
        HexEditForm hexEditForm;

        bool attachedToProcess = false;
        bool writingToProcess = false;
        bool displayActualValues = true;
        bool varConversionsActive = false;
       


        public Form1()
        {
            InitializeComponent();
            modAddresses = new List<ModAddress>();
            modAddressControls = new List<ModAddressControl>();
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
                currentProcess = attachForm.selectedProcess;
                lbl_process.Text = currentProcess.ProcessName;
                lbl_pid.Text = currentProcess.Id.ToString();
                lbl_attached_status.Text = "Attached";
                lbl_attached_status.ForeColor = Color.Green;
                btn_toggle_writing_to_process.Enabled = true;
                attachedToProcess = true;
                varConversionsActive = true;
                btn_open_hex.Enabled = true;
                memoryModifier = new MemoryModifier(currentProcess);


                updateTimer.Start();
            }

        }

        private void btn_open_hex_Click(object sender, EventArgs e)
        {
           
            if (lb_mod_addresses.SelectedIndex != -1)
            {
                hexEditForm = new HexEditForm(modAddresses[lb_mod_addresses.SelectedIndex].address, memoryModifier);
            }
            else
            {
                hexEditForm = new HexEditForm(0x00000, memoryModifier);
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
            modAddresses.Add(m);

            ModAddressControl modAddressControl = new ModAddressControl(m, false);

            modAddressControl.Location = new Point(modAddressControl.Location.X, ModAddressControl.size_y * (modAddresses.Count - 1) + panel_mod_addresses.AutoScrollPosition.Y);
            modAddressControls.Add(modAddressControl);

            panel_mod_addresses.Controls.Add(modAddressControl);

            lb_mod_addresses.Items.Add(m.name);
              
            
        }

        private void RemoveModAddress(int index)
        {
            if (index >= 0)
            {
                modAddresses.Remove(modAddresses[index]);

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
                catch
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

        private void btn_test_iterate_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_add_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (displayActualValues)
            {
                foreach (ModAddressControl m in modAddressControls)
                {
                    m.UpdateActualValueLabel(memoryModifier);
                }
                
            }


            if (writingToProcess)
            {
                foreach (ModAddressControl m in modAddressControls)
                {
                    if (m.getIsActive())
                    {
                        if (m.getModAddress().type == (int)ModAddress.Types.Byte)
                        {
                            memoryModifier.WriteToAddress(m.getModAddress().address, (byte)((int)m.getModAddress().value));
                        }

                        else if (m.getModAddress().type == (int)ModAddress.Types.Float)
                        {
                            memoryModifier.WriteToAddress(m.getModAddress().address, (float)(m.getModAddress().value));
                        }

                    }
                }
            }

            if (lb_mod_addresses.SelectedIndex != -1 && varConversionsActive)
            {
                UpdateVarConversions(modAddresses[lb_mod_addresses.SelectedIndex].address);
            }


           
        }

        private void UpdateVarConversions(Int32 address)
        {
            lbl_var_as_byte.Text = Convert.ToString((int)memoryModifier.ReadFromAddress(address, 1)[0]);

            int i = BitConverter.ToInt16(memoryModifier.ReadFromAddress(address, 2), 0);
            lbl_var_as_short.Text = i.ToString();

            float f = BitConverter.ToSingle(memoryModifier.ReadFromAddress(address, 4), 0);
            lbl_var_as_float.Text = f.ToString();

            double d = BitConverter.ToDouble(memoryModifier.ReadFromAddress(address, 8), 0);
            lbl_var_as_double.Text = d.ToString();


      
        }

        private void menu_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            btn_save.PerformClick();
        }
         private void menu_load_Click(object sender, EventArgs e)
        {
            btn_load.PerformClick();
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

                     ModAddress modAddress = new ModAddress(address,name,min,max,value,type);
                     AddModAddress(modAddress);
                 }
             }
             catch { MessageBox.Show("Load Settings Error"); }
         }

        private void WriteToFile(string path)
        {

            XElement xmlDocument = new XElement("Addresses");
            foreach (ModAddress m in modAddresses)
            {
                XElement xml_ma = new XElement("Address",
                new XElement("address", m.address),
                new XElement("name", m.name),
                new XElement("min", m.min),
                new XElement("max", m.max),
                new XElement("value", m.value),
                new XElement("type", m.type) 
                );

                xmlDocument.Add(xml_ma);
               
            }
            

            xmlDocument.Save(path);
        }

        private void lb_mod_addresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_mod_addresses.SelectedIndex != -1)
            {
                panel_mod_addresses.AutoScrollPosition = new Point(0, ModAddressControl.size_y * lb_mod_addresses.SelectedIndex);
                lbl_var_name.Text = lb_mod_addresses.SelectedItem.ToString();
                lbl_var_address.Text = modAddressControls[lb_mod_addresses.SelectedIndex].getModAddress().address.ToString("X");
            }
        }

        private void UpdateHexBox(Int32 start_address)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btn_remove_address_Click(object sender, EventArgs e)
        {
            RemoveModAddress(lb_mod_addresses.SelectedIndex);
        }

        private void btn_toggle_writing_to_process_Click(object sender, EventArgs e)
        {
            ToggleWritingToProcess();
        }


    
        private void panel_mod_addresses_Scroll(object sender, ScrollEventArgs e) ///smooths panel scrolling down, but really slow
        {
          

        Control control = sender as Control;
        if (control!=null)
        {
            if (e.Type == ScrollEventType.ThumbTrack)
            {
                // Enable drawing
                SendMessage(control.Handle, WM_SETREDRAW, 1, 0);
                // Refresh the control 
                control.Refresh();
                // Disable drawing                            
                SendMessage(control.Handle, WM_SETREDRAW, 0, 0);
            }
            else
            {
                // Enable drawing
                SendMessage(control.Handle, WM_SETREDRAW, 1, 0);
                control.Invalidate();
            }
       
       } 
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void lbl_attached_status_Click(object sender, EventArgs e)
        {
          
        }

        private void lbl_attached_status_DoubleClick(object sender, EventArgs e)
        {
            if (!attachedToProcess)
            {
                AttachToProcess();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

  




    





       
    }
}
