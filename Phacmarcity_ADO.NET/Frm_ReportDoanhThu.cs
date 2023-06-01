using Microsoft.Reporting.WinForms;
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
    public partial class Frm_ReportDoanhThu : Form
    {
        public Frm_ReportDoanhThu()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_ReportDoanhThu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


            // Thiết lập chế độ hiển thị của ReportViewer
            reportViewer1.RefreshReport();
        }

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private DataTable GetDataFromDatabase()
        {
            // Thực hiện truy vấn cơ sở dữ liệu hoặc xử lý dữ liệu từ nguồn khác
            DataTable dataTable = new DataTable();

            // Code để lấy dữ liệu vào dataTable

            return dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn cơ sở dữ liệu hoặc xử lý dữ liệu từ nguồn khác
                DataTable dataTable = GetDataFromDatabase(); // Ví dụ: Lấy dữ liệu từ cơ sở dữ liệu

                // Gắn dữ liệu vào ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable)); // "DataSet1" là tên nguồn dữ liệu trong báo cáo

                // Refresh và hiển thị báo cáo
                reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
                    
        }
    }
}
