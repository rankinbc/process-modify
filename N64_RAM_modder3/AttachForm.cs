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
            listProcesses();
            tb_process.Focus();
          
        }

        private void listProcesses()
        {
            for (int i = 0; i < processes.Length; i++)
            {
                lb_processes.Items.Add(processes[i].ProcessName);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
        //    selectedProcess = processes[lb_processes.SelectedIndex];

            try
            {
                selectedProcess = processes[lb_processes.FindStringExact(tb_process.Text)];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Process not found");
            }
           
            
           
        }

        private void lb_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_process.Text = lb_processes.SelectedItem.ToString();
        }

        private void lb_processes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_select.PerformClick();
        }

       
    }
}
