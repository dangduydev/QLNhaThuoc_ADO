using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_ReportPhieuXuat : Form
    {
        public Frm_ReportPhieuXuat()
        {
            InitializeComponent();
        }

        private void Frm_ReportPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPhieuXuatReport.DataTable1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dsPhieuXuatReport.DataTable1' table. You can move, or remove it, as needed.
            /*            this.dataTable1TableAdapter.Fill(this.dsPhieuXuatReport.DataTable1);*/

            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.dsPhieuXuatReport.DataTable1, maPXToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
