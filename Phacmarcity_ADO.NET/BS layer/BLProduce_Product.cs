using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLProduce_Product
    {
        DBMain db = null;
        public BLProduce_Product()
        {
            db = new DBMain();
        }
        public DataSet LayPhieuXuat()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM PhieuXuat JOIN CTPhieuXuat ON PhieuXuat.MaPX = CTPhieuXuat.MaPX", CommandType.Text);
        }
        public bool ThemPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, string MaThuoc, string SoLuong, string DonGia, DateTime NgayXuat, ref string err)
        {
            // Kiểm tra số lượng trong bảng "Thuốc"
            string query = "SELECT SoLuong FROM Thuoc WHERE MaThuoc = '" + MaThuoc + "'";
            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text);

            if (result.Tables[0].Rows.Count > 0)
            {
                int soLuongTrongKho = Convert.ToInt32(result.Tables[0].Rows[0]["SoLuong"]);
                int soLuongXuat = Convert.ToInt32(SoLuong);

                if (soLuongXuat > soLuongTrongKho)
                {
                    // Số lượng xuất vượt quá số lượng trong kho
                    err = "Số lượng xuất vượt quá số lượng trong kho!";
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (soLuongXuat <= 0)
                {
                    // Số lượng xuất không hợp lệ
                    err = "Số lượng xuất không hợp lệ!";
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Không tìm thấy thông tin thuốc trong bảng "Thuốc"
                err = "Không tìm thấy thông tin thuốc!";
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Thêm phiếu xuất
            string sqlString = "INSERT INTO PhieuXuat (MaPX, MaNhanVien, MaKhachHang, NgayXuat) VALUES ('" + MaPX + "', '" + MaNhanVien + "', '" + MaKhachHang + "', '" + NgayXuat.ToString("yyyy-MM-dd") + "');" +
                       "INSERT INTO CTPhieuXuat (MaPX, MaThuoc, SoLuong, DonGia) VALUES ('" + MaPX + "', '" + MaThuoc + "', " + SoLuong + ", " + DonGia + ");";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }




        public DataSet TimKiemPhieuXuat(string input, string tuKhoa)
        {
            string query = @"WITH PhieuXuatNew AS (
                        SELECT PhieuXuat.MaPx, PhieuXuat.MaNhanVien, PhieuXuat.MaKhachHang, PhieuXuat.NgayXuat, CTPhieuXuat.MaThuoc, CTPhieuXuat.SoLuong, CTPhieuXuat.DonGia
                        FROM PhieuXuat
                        JOIN CTPhieuXuat ON PhieuXuat.MaPX = CTPhieuXuat.MaPX
                    )
                    SELECT *
                    FROM PhieuXuatNew
                    WHERE ";

            switch (input)
            {
                case nameof(Cls_Enum.OptionPhieuXuat.MaPX):
                case nameof(Cls_Enum.OptionPhieuXuat.MaNhanVien):
                case nameof(Cls_Enum.OptionPhieuXuat.MaKhachHang):
                    query += "PhieuXuatNew." + input + " LIKE '%" + tuKhoa + "%'";
                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.NgayXuat):
                    query += "PhieuXuatNew." + input + " = '" + tuKhoa + "'";
                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.SoLuong):
                case nameof(Cls_Enum.OptionPhieuXuat.MaThuoc):
                case nameof(Cls_Enum.OptionPhieuXuat.DonGia):
                    query += "PhieuXuatNew." + input + " LIKE '%" + tuKhoa + "%'";
                    break;

                default:
                    break;
            }
            return db.ExecuteQueryDataSet(query, CommandType.Text);

        }

        public bool XoaPhieuXuat(ref string err, string MaPX)
        {
            string sqlString = "DELETE FROM CTPhieuXuat WHERE MaPX = '" + MaPX + "';" +
                               "DELETE FROM PhieuXuat WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, string MaThuoc, string SoLuong, string DonGia, DateTime NgayXuat, ref string err)
        {
            string sqlString = "UPDATE PhieuXuat SET MaNhanVien = N'" + MaNhanVien + "', MaKhachHang = '" + MaKhachHang + "', NgayXuat = '" + NgayXuat.ToString("yyyy-MM-dd") + "' WHERE MaPX = '" + MaPX + "';" +
                               "UPDATE CTPhieuXuat SET MaThuoc = N'" + MaThuoc + "', SoLuong = " + SoLuong + ", DonGia = " + DonGia + " WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
