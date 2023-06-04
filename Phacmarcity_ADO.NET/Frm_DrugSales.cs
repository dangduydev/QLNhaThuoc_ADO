﻿using Phacmarcity_ADO.NET.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_DrugSales : Form
    {
        DataTable dtDoanhThu = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        string err;
        BLDrugSales dbTP = new BLDrugSales();

        public Frm_DrugSales()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                decimal doanhThu = dbTP.TongDoanhThu(ref err);

                txtDoanhThu.Text = doanhThu.ToString("N0");
                /*                reset();*/
                dtDoanhThu = new DataTable();
                dtDoanhThu.Clear();
                DataSet ds = dbTP.LaySLThuoc();
                dtDoanhThu = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvDoanhThuThuoc.DataSource = dtDoanhThu;
                // Thay đổi độ rộng cột 
                dgvDoanhThuThuoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //dgvPhieuNhap_CellClick(null, null);
                txtDoanhThu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Trong CSDL. Lỗi rồi!!!");
            }
        }
        private void dgvDoanhThuThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_DrugSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtDoanhThu_TextChanged(object sender, EventArgs e)
        {
            decimal doanhThu = dbTP.TongDoanhThu( ref err);

            txtDoanhThu.Text = doanhThu.ToString("N0");

        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrintReview_Click(object sender, EventArgs e)
        {
            Form f = new Frm_ReportDoanhThu();
            f.ShowDialog();
        }
    }
}
