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
        public bool CapNhatSLThuoc(ref string err)
        {
            string sqlString = @"UPDATE Thuoc
                         SET SoLuong = ISNULL(tongNhap.SoLuong, 0) - ISNULL(tongXuat.SoLuong, 0)
                         FROM Thuoc
                         LEFT JOIN (
                             SELECT MaThuoc, SUM(SoLuong) AS SoLuong
                             FROM CTPhieuNhap
                             GROUP BY MaThuoc
                         ) AS tongNhap ON Thuoc.MaThuoc = tongNhap.MaThuoc
                         LEFT JOIN (
                             SELECT MaThuoc, SUM(SoLuong) AS SoLuong
                             FROM CTPhieuXuat
                             GROUP BY MaThuoc
                         ) AS tongXuat ON Thuoc.MaThuoc = tongXuat.MaThuoc";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatThuoc(string MaThuoc, string TenThuoc, string MaHangSX, string MaNhaCungCap, string CongDung, string GhiChu, int SoLuong, ref string err)
        {
            string sqlString = "Update Thuoc Set TenThuoc=N'" +
            TenThuoc + "', MaHangSX= N'" + MaHangSX + "', MaNhaCungCap= N'" + MaNhaCungCap + "', CongDung= N'" + CongDung + "', GhiChu= N'" + GhiChu  + "', SoLuong= '" + SoLuong + "' Where MaThuoc='" + MaThuoc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}

