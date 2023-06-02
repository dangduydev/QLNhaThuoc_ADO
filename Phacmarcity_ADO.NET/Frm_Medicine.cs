using Phacmarcity_ADO.NET.BS_layer;
using Phacmarcity_ADO.NET.Class;
using Phacmarcity_ADO.NET.ENUM;
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
    public partial class Frm_Medicine : Form
    {
        DataTable dtThuoc = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLThuoc dbTP = new BLThuoc();
        public Frm_Medicine()
        {
            InitializeComponent();
        }
        void reset()
        {
            foreach (Control control in pnlMain.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
            }
            pnlSearch.Enabled = false;
        }
        void LoadData()
        {
            try
            {
                dbTP.CapNhatSLThuoc(ref err);
                reset();
                dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtThuoc = new DataTable();
                dtThuoc.Clear();
                DataSet ds = dbTP.LayThuoc();
                dtThuoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvThuoc.DataSource = dtThuoc;
                // Thay đổi độ rộng cột 
                dgvThuoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtKhachHang.ResetText();
                this.TenThuoc.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                //dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Thuoc. Lỗi rồi!!!");
            }
        }
        void LoadDataSearch(string input, string key)
        {
            try
            {
                dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtThuoc = new DataTable();
                dtThuoc.Clear();
                DataSet ds = dbTP.TimKiemThuoc(input, key);
                dtThuoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvThuoc.DataSource = dtThuoc;
                // Thay đổi độ rộng cột 
                dgvThuoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtKhachHang.ResetText();
                this.TenThuoc.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Thuoc. Lỗi rồi!!!");

            }
        }
        private void picNCC_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Supplier();
            f.ShowDialog();
        }

        private void picHangSX_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Manufacturer();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Panel 
            reset();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtKhachHang 
            this.TenThuoc.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvThuoc_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.TenThuoc.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối 
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLThuoc blTp = new BLThuoc();
                    blTp.ThemThuoc(this.MaThuoc.Text, this.TenThuoc.Text, this.MaHangSX.Text, this.MaNhaCungCap.Text, this.CongDung.Text, this.MaLoai.Text, this.GhiChu.Text, ref err);
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    reset();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLThuoc blTp = new BLThuoc();
                blTp.CapNhatThuoc(this.MaThuoc.Text, this.TenThuoc.Text, this.MaHangSX.Text, this.MaNhaCungCap.Text, this.CongDung.Text, this.GhiChu.Text, int.Parse(this.txtSoLuong.Text), ref err);
                // Load lại dữ liệu trên DataGridView 
                LoadData();
                reset();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
            pnlMain.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvThuoc.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strThuoc =
                dgvThuoc.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbTP.XoaThuoc(ref err, strThuoc);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvThuoc_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.txtSoLuong.Enabled = false;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.TenThuoc.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.TenThuoc.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            pnlMain.Enabled = false;
            dgvThuoc_CellClick(null, null);
            reset();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvThuoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.MaThuoc.Text =
            dgvThuoc.Rows[r].Cells[0].Value.ToString();
            this.TenThuoc.Text =
            dgvThuoc.Rows[r].Cells[1].Value.ToString();
            this.MaHangSX.Text =
            dgvThuoc.Rows[r].Cells[2].Value.ToString();
            this.MaLoai.Text =
            dgvThuoc.Rows[r].Cells[3].Value.ToString();
            this.CongDung.Text =
            dgvThuoc.Rows[r].Cells[4].Value.ToString();
            this.MaLoai.Text =
            dgvThuoc.Rows[r].Cells[5].Value.ToString();
            this.GhiChu.Text =
            dgvThuoc.Rows[r].Cells[6].Value.ToString();
        }

        private void Frm_Medicine_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null && cbxTimKiem.SelectedIndex != -1)
            {

                string typeSearch = StringConvert.ConvertToEnumMedicine(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionThuoc.MaThuoc):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.TenThuoc):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.MaHangSX):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.MaNhaCungCap):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.CongDung):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.MaLoai):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionThuoc.GhiChu):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    default:
                        break;
                }

            }
        }

        private void GhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
