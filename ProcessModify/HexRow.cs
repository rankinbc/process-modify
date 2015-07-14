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
    public partial class HexRow : UserControl
    {
        public Int32 startAddress;
        HexEditForm parentForm;

        public HexRow() { }
        public HexRow(Int32 address, HexEditForm form)
        {
            InitializeComponent();
            startAddress = address;
            parentForm = form;
        }
       
        private void HexRow_Load(object sender, EventArgs e)
        {
            string startAddressString = startAddress.ToString("X8");
            startAddressString = startAddressString.Remove(startAddressString.Length - 1, 1);
            lbl_start_address.Text = startAddressString;
        }

        public void reset(Int32 startAdd)
        {
            string startAddressString = startAdd.ToString("X8");
            startAddressString = startAddressString.Remove(startAddressString.Length - 1, 1);
            lbl_start_address.Text = startAddressString;
        }

        public void updateTextBoxes(byte[] b)
        {
            tb0.Text = b[0].ToString("X2");
            tb1.Text = b[1].ToString("X2");
            tb2.Text = b[2].ToString("X2");
            tb3.Text = b[3].ToString("X2");
            tb4.Text = b[4].ToString("X2");
            tb5.Text = b[5].ToString("X2");
            tb6.Text = b[6].ToString("X2");
            tb7.Text = b[7].ToString("X2");
            tb8.Text = b[8].ToString("X2");
            tb9.Text = b[9].ToString("X2");
            tbA.Text = b[10].ToString("X2");
            tbB.Text = b[11].ToString("X2");
            tbC.Text = b[12].ToString("X2");
            tbD.Text = b[13].ToString("X2");
            tbE.Text = b[14].ToString("X2");
            tbF.Text = b[15].ToString("X2");
        }

        private void tb0_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 0);
        }

        private void tb1_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 1);
        }

        private void tb2_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 2);
        }

        private void tb3_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress( startAddress + 3);
        }

        private void tb4_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 4);
        }

        private void tb5_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(  startAddress + 5);
        }

        private void tb6_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(  startAddress + 6);
        }

        private void tb7_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(  startAddress + 7);
        }

        private void tb8_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(  startAddress + 8);
        }

        private void tb9_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress( startAddress + 9);
        }

        private void tbA_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress( startAddress + 10);
        }

        private void tbB_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress( startAddress + 11);
        }

        private void tbC_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress( startAddress + 12);
        }

        private void tbD_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 13);
        }

        private void tbE_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 14);
        }

        private void tbF_Click(object sender, EventArgs e)
        {
            parentForm.changeSelectedAddress(startAddress + 15);
        }
    }
}
