using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLDrugSales
    {
        DBMain db = null;
        public BLDrugSales()
        {
            db = new DBMain();
        }
        public DataSet LayNCC()
        {
            return db.ExecuteQueryDataSet("SELECT CTPhieuNhap.MaThuoc, CTPhieuNhap.SoLuong, CTPhieuNhap.DonGia, CTPhieuXuat.MaThuoc, CTPhieuXuat.DonGia, CTPhieuNhap.NgaySX, CTPhieuNhap.NgayHH from CTPhieuNhap join CTPhieuXuat on CTPhieuNhap.MaThuoc = CTPhieuXuat.MaThuoc", CommandType.Text);
        }
        public bool ThemNCC(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string ThongTinDaiDien, ref string err)
        {
            string sqlString = "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, ThongTinDaiDien) VALUES ('" + MaNhaCungCap + "', N'" + TenNhaCungCap + "', N'" + DiaChi + "', N'" + ThongTinDaiDien + "');";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemNCC(string input, string key)
        {
            return db.ExecuteQueryDataSet("select * from NhaCungCap Where " + input + " like '%" + key + "%'", CommandType.Text);
        }

        public bool XoaNCC(ref string err, string MaNhaCungCap)
        {
            string sqlString = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = '" + MaNhaCungCap + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatNCC(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string ThongTinDaiDien, ref string err)
        {
            string sqlString = "UPDATE NhaCungCap SET MaNhaCungCap = N'" + MaNhaCungCap +
                "', TenNhaCungCap = N'" + TenNhaCungCap +
                "', DiaChi = N'" + DiaChi +
                "', ThongTinDaiDien = N'" + ThongTinDaiDien +
                "' WHERE MaNhaCungCap = '" + MaNhaCungCap + "';";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
