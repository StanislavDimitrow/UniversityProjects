using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Maintenance
{
    public partial class JobDetails : Form
    {
        public JobDetails()
        {
            InitializeComponent();
        }

        private void txtbCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtbCarNo.Text == "") || (txtbCarNo.Text == null))
            {
                MessageBox.Show("Pleae specify a valid value for the car number", "Error in input");
                txtbCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please specify a valid value for the car number");
                txtbCarNo.Focus();
                return;
            }
            try
            {
                if (Convert.ToInt32(txtbWorkerID.Text) < 1)
                {
                    MessageBox.Show("Please specify a valid woker ID");
                    txtbWorkerID.Focus();
                    return;
                }
                if(Convert.ToDateTime(dateTimePicker1.Value)>DateTime.Today)
                {
                    MessageBox.Show("Please specify a valid date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
