using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    partial class Frm_Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MaHangSX = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaThuoc = new System.Windows.Forms.TextBox();
            this.TenThuoc = new System.Windows.Forms.TextBox();
            this.CongDung = new System.Windows.Forms.TextBox();
            this.MaLoai = new System.Windows.Forms.TextBox();
            this.GhiChu = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picHangSX = new System.Windows.Forms.PictureBox();
            this.picNCC = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaNhaCungCap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(3, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 27);
            this.textBox2.TabIndex = 193;
            // 
            // MaHangSX
            // 
            this.MaHangSX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MaHangSX.Location = new System.Drawing.Point(3, 71);
            this.MaHangSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaHangSX.Name = "MaHangSX";
            this.MaHangSX.Size = new System.Drawing.Size(169, 27);
            this.MaHangSX.TabIndex = 193;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(35, 452);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 41);
            this.btnSearch.TabIndex = 192;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(289, 528);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 41);
            this.btnSave.TabIndex = 191;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(393, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 28);
            this.label13.TabIndex = 186;
            this.label13.Text = "Hãng sản xuất";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(110, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 28);
            this.label11.TabIndex = 184;
            this.label11.Text = "Nhà cung cấp";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 580);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 41);
            this.btnEdit.TabIndex = 179;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(32, 580);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 41);
            this.btnDelete.TabIndex = 178;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(31, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 28);
            this.label9.TabIndex = 173;
            this.label9.Text = "Công dụng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.Location = new System.Drawing.Point(4, 138);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(169, 27);
            this.txtSoLuong.TabIndex = 172;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaNhanVien.Location = new System.Drawing.Point(3, 37);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(169, 27);
            this.txtMaNhanVien.TabIndex = 168;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 22);
            this.panel2.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(430, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Managerment Version 1.0";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.AutoSize = true;
            this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaNCC.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtMaNCC.Location = new System.Drawing.Point(31, 254);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(181, 28);
            this.txtMaNCC.TabIndex = 170;
            this.txtMaNCC.Text = "Mã hãng sản xuất";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.GridColor = System.Drawing.Color.White;
            this.dgvThuoc.Location = new System.Drawing.Point(447, 192);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 29;
            this.dgvThuoc.Size = new System.Drawing.Size(826, 405);
            this.dgvThuoc.TabIndex = 166;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 528);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 165;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(31, 528);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 164;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(31, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 158;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt.Location = new System.Drawing.Point(3, 2);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(169, 27);
            this.txt.TabIndex = 156;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 87);
            this.panel1.TabIndex = 155;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(3, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 195;
            this.label2.Text = "Mã thuốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(31, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 28);
            this.label7.TabIndex = 196;
            this.label7.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(30, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 198;
            this.label4.Text = "Ghi chú";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(2, 175);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 27);
            this.textBox3.TabIndex = 197;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(799, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 50);
            this.label16.TabIndex = 190;
            this.label16.Text = "Thuốc";
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxTimKiem.FormattingEnabled = true;
            this.cbxTimKiem.Items.AddRange(new object[] {
            "Mã thuốc",
            "Tên thuốc",
            "Mã hãng sản xuất",
            "Mã nhà cung cấp"});
            this.cbxTimKiem.Location = new System.Drawing.Point(3, 2);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Size = new System.Drawing.Size(169, 28);
            this.cbxTimKiem.TabIndex = 203;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTimKiem.Location = new System.Drawing.Point(4, 39);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(169, 27);
            this.txtTimKiem.TabIndex = 202;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(135, 422);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 28);
            this.label19.TabIndex = 201;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txt);
            this.pnlMain.Controls.Add(this.txtMaNhanVien);
            this.pnlMain.Controls.Add(this.txtSoLuong);
            this.pnlMain.Controls.Add(this.textBox2);
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.textBox3);
            this.pnlMain.Location = new System.Drawing.Point(230, 189);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(184, 201);
            this.pnlMain.TabIndex = 204;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cbxTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Location = new System.Drawing.Point(230, 450);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(180, 70);
            this.pnlSearch.TabIndex = 205;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MaNhaCungCap);
            this.panel3.Controls.Add(this.MaThuoc);
            this.panel3.Controls.Add(this.TenThuoc);
            this.panel3.Controls.Add(this.CongDung);
            this.panel3.Controls.Add(this.MaHangSX);
            this.panel3.Controls.Add(this.MaLoai);
            this.panel3.Controls.Add(this.GhiChu);
            this.panel3.Location = new System.Drawing.Point(230, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 240);
            this.panel3.TabIndex = 204;
            // 
            // MaThuoc
            // 
            this.MaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MaThuoc.Location = new System.Drawing.Point(3, 2);
            this.MaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Size = new System.Drawing.Size(169, 27);
            this.MaThuoc.TabIndex = 156;
            // 
            // TenThuoc
            // 
            this.TenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TenThuoc.Location = new System.Drawing.Point(3, 37);
            this.TenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Size = new System.Drawing.Size(169, 27);
            this.TenThuoc.TabIndex = 168;
            // 
            // CongDung
            // 
            this.CongDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CongDung.Location = new System.Drawing.Point(4, 138);
            this.CongDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CongDung.Name = "CongDung";
            this.CongDung.Size = new System.Drawing.Size(169, 27);
            this.CongDung.TabIndex = 172;
            // 
            // MaLoai
            // 
            this.MaLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MaLoai.Location = new System.Drawing.Point(4, 172);
            this.MaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Size = new System.Drawing.Size(169, 27);
            this.MaLoai.TabIndex = 194;
            // 
            // GhiChu
            // 
            this.GhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.GhiChu.Location = new System.Drawing.Point(2, 206);
            this.GhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(169, 27);
            this.GhiChu.TabIndex = 197;
            this.GhiChu.TextChanged += new System.EventHandler(this.GhiChu_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(288, 580);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 206;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picHangSX
            // 
            this.picHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHangSX.Image = global::Phacmarcity_ADO.NET.Properties.Resources.production;
            this.picHangSX.Location = new System.Drawing.Point(311, 92);
            this.picHangSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHangSX.Name = "picHangSX";
            this.picHangSX.Size = new System.Drawing.Size(63, 35);
            this.picHangSX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHangSX.TabIndex = 182;
            this.picHangSX.TabStop = false;
            this.picHangSX.Click += new System.EventHandler(this.picHangSX_Click);
            // 
            // picNCC
            // 
            this.picNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCC.Image = global::Phacmarcity_ADO.NET.Properties.Resources.nha_cung_cap;
            this.picNCC.Location = new System.Drawing.Point(41, 92);
            this.picNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNCC.Name = "picNCC";
            this.picNCC.Size = new System.Drawing.Size(63, 35);
            this.picNCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNCC.TabIndex = 180;
            this.picNCC.TabStop = false;
            this.picNCC.Click += new System.EventHandler(this.picNCC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(30, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 207;
            this.label5.Text = "Mã Loại";
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MaNhaCungCap.Location = new System.Drawing.Point(2, 105);
            this.MaNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Size = new System.Drawing.Size(169, 27);
            this.MaNhaCungCap.TabIndex = 198;
            // 
            // Frm_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picHangSX);
            this.Controls.Add(this.picNCC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.Frm_Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private Button btnSave;
        private Label label13;
        private Label label11;
        private PictureBox picHangSX;
        private PictureBox picNCC;
        private Button btnEdit;
        private Button btnDelete;
        private Label label9;
        private TextBox txtSoLuong;
        private ComboBox comboBox1;
        private Label txtTenThuoc;
        private TextBox txtMaNhanVien;
        private Panel panel2;
        private Label label1;
        private Label txtMaNCC;
        private DataGridView dgvThuoc;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbbMaThuoc;
        private Label label3;
        private Label txtMaThuoc;
        private TextBox txt;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label7;
        private Label label4;
        private TextBox textBox3;
        private Label label16;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Panel pnlMain;
        private Panel pnlSearch;
        private Panel panel3;
        private TextBox MaThuoc;
        private TextBox TenThuoc;
        private TextBox CongDung;
        private TextBox MaLoai;
        private TextBox GhiChu;
        private Button btnCancel;
        private TextBox textBox2;
        private TextBox MaHangSX;
        private Label label5;
        private TextBox MaNhaCungCap;
    }
}