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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMS2YDataSet.tblWorker' table. You can move, or remove it, as needed.
            this.tblWorkerTableAdapter.Fill(this.cMS2YDataSet.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cMS2YDataSet.Clear();
            tblWorkerTableAdapter.Fill(cMS2YDataSet);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            tblWorkerBindingSource.EndEdit();
            tblWorkerAdapter1.Update(cMS2YDataSet);
            MessageBox.Show("The Worker table is updated.");

        }
    }
}
