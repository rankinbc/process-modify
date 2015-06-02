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
        public HexRow(Int32 address, HexEditForm form)
        {
            InitializeComponent();
            startAddress = address;
            parentForm = form;
           
        }
        public HexRow()
        {

        }

        private void HexRow_Load(object sender, EventArgs e)
        {
            lbl_start_address.Text = startAddress.ToString("X").TrimEnd('0');
            lbl_start_address.Text = lbl_start_address.Text.PadLeft(7,'0');
      
        }

        public void reset(Int32 startAdd)
        {
            startAddress = startAdd;
            lbl_start_address.Text = startAddress.ToString("X").TrimEnd('0');
            lbl_start_address.Text = lbl_start_address.Text.PadLeft(7, '0');
        }

        public void updateTextBoxes(byte[] b)
        {
            tb0.Text = b[0].ToString("X").PadLeft(2,'0');
            tb1.Text = b[1].ToString("X").PadLeft(2, '0');
            tb2.Text = b[2].ToString("X").PadLeft(2, '0');
            tb3.Text = b[3].ToString("X").PadLeft(2, '0');
            tb4.Text = b[4].ToString("X").PadLeft(2, '0');
            tb5.Text = b[5].ToString("X").PadLeft(2, '0');
            tb6.Text = b[6].ToString("X").PadLeft(2, '0');
            tb7.Text = b[7].ToString("X").PadLeft(2, '0');
            tb8.Text = b[8].ToString("X").PadLeft(2, '0');
            tb9.Text = b[9].ToString("X").PadLeft(2, '0');
            tbA.Text = b[10].ToString("X").PadLeft(2, '0');
            tbB.Text = b[11].ToString("X").PadLeft(2, '0');
            tbC.Text = b[12].ToString("X").PadLeft(2, '0');
            tbD.Text = b[13].ToString("X").PadLeft(2, '0');
            tbE.Text = b[14].ToString("X").PadLeft(2, '0');
            tbF.Text = b[15].ToString("X").PadLeft(2, '0');
        }

        private void tb0_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {

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
