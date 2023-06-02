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
        public DataSet LaySLThuoc()
        {
            return db.ExecuteQueryDataSet("SELECT\r\n   " +
                " CTPhieuNhap.MaThuoc,Thuoc.TenThuoc,CTPhieuNhap.SoLuong as 'So Luong Nhap',CTPhieuNhap.DonGia as 'Gia Nhap',CTPhieuXuat.SoLuong as 'So Luong Ban',CTPhieuXuat.DonGia as 'Gia Ban',\r\n " +
                "   (CTPhieuXuat.SoLuong * (CTPhieuXuat.DonGia - CTPhieuNhap.DonGia)) AS DoanhThu\r\n" +
                "FROM\r\n    CTPhieuNhap \r\n" +
                "JOIN\r\n    CTPhieuXuat  ON CTPhieuNhap.MaThuoc = CTPhieuXuat.MaThuoc\r\n" +
                "JOIN\r\n\t   Thuoc ON CTPhieuNhap.MaThuoc= Thuoc.MaThuoc", CommandType.Text);
        }
        public decimal TongDoanhThu(ref string err)
        {
            decimal tongDoanhThu = 0;
            string sqlString = "SELECT SUM(DoanhThu) AS TongDoanhThu FROM (SELECT CTPhieuNhap.MaThuoc, Thuoc.TenThuoc, CTPhieuNhap.SoLuong AS 'So Luong Nhap', CTPhieuNhap.DonGia AS 'Gia Nhap', CTPhieuXuat.SoLuong AS 'So Luong Ban', CTPhieuXuat.DonGia AS 'Gia Ban', (CTPhieuXuat.SoLuong * (CTPhieuXuat.DonGia - CTPhieuNhap.DonGia)) AS DoanhThu FROM CTPhieuNhap JOIN CTPhieuXuat ON CTPhieuNhap.MaThuoc = CTPhieuXuat.MaThuoc JOIN Thuoc ON CTPhieuNhap.MaThuoc = Thuoc.MaThuoc) AS T";
            object result = db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
            if (result != null && result != DBNull.Value)
            {
                tongDoanhThu = Convert.ToDecimal(result);
            }
            return tongDoanhThu;
        }



    }
}
