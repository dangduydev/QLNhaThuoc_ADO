using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLThuoc
    {
        DBMain db = null;

        public BLThuoc()
        {
            db = new DBMain();
        }
        public DataSet LayThuoc()
        {
            return db.ExecuteQueryDataSet("select * from Thuoc", CommandType.Text);
        }
        public DataSet TimKiemThuoc(string input, string key)
        {
            return db.ExecuteQueryDataSet("select * from Thuoc Where " + input + " like '%" + key + "%'", CommandType.Text);
        }
        public bool ThemThuoc(string MaThuoc, string TenThuoc, string MaHangSX, string MaNhaCungCap, string CongDung, string MaLoai, string GhiChu, ref string err)
        {
            string sqlString = "Insert Into Thuoc Values('" +
            MaThuoc + "', N'" +
            TenThuoc + "', N'" + MaHangSX + "', N'" + MaNhaCungCap + "', N'" + CongDung + "', N'" + MaLoai + "', N'" + GhiChu + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaThuoc(ref string err, string MaThuoc)
        {
            string sqlString = "Delete From Thuoc Where MaThuoc='" + MaThuoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThuoc(string MaThuoc, string TenThuoc, string MaHangSX, string MaNhaCungCap, string CongDung, string MaLoai, string GhiChu, ref string err)
        {
            string sqlString = "Update Thuoc Set TenThuoc=N'" +
            TenThuoc + "', MaHangSX= N'" + MaHangSX + "', MaNhaCungCap= N'" + MaNhaCungCap + "', CongDung= N'" + CongDung + "', MaLoai= N'" + MaLoai + "', GhiChu= N'" + GhiChu + "' Where MaThuoc='" + MaThuoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}

