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

namespace ProcessModify
{
    public partial class AttachForm : Form
    {
        private Process[] processes;
        public Process selectedProcess { get; set; }
       
        public AttachForm()
        {
            InitializeComponent();
        }

        private void AttachForm_Load(object sender, EventArgs e)
        {
            processes = Process.GetProcesses();
            ListProcesses();
            tb_process.Focus(); 
        }


        private void ListProcesses()
        {
            for (int i = 0; i < processes.Length; i++)
            {
                lb_processes.Items.Add(processes[i].ProcessName);
            }
        }

        private void SelectProcess(String processString)
        {
            try
            {
                selectedProcess = processes[lb_processes.FindStringExact(processString)];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("Process not found: " + e.ToString());
            }   
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SelectProcess(tb_process.Text);
        } 

        private void lb_processes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectProcess(tb_process.Text);
        }    

        private void lb_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_process.Text = lb_processes.SelectedItem.ToString();
        }

        private void AttachForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            SelectProcess(tb_process.Text);
        }

        private void btn_select_mupen_Click(object sender, EventArgs e) //temporary
        {      
            SelectProcess("mupen64");
        }
    }
}
