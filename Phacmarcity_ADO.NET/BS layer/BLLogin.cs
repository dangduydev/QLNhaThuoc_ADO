using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phacmarcity_ADO.NET.BS_layer
{

    class BLLogin
    {
        bool kiemTra = false;
        DBMain db = null;

        public BLLogin()
        {
            db = new DBMain();
            db.ConnectionString = "Data Source=(local);Initial Catalog=QLNhaThuoc;Integrated Security=True";
        }

        public DataSet LayTaiKhoan()
        {
            db.ConnectionString = "Data Source=(local);Initial Catalog=QLNhaThuoc;Integrated Security=True";
            return db.ExecuteQueryDataSet("SELECT * FROM TaiKhoan", CommandType.Text);
        }
        public bool KiemTraDangNhap(string Username, string Pass)
        {
            string sqlString = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNhanVien = @Username AND MatKhau = @Pass";
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var command = new SqlCommand(sqlString, conn))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Pass", Pass);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}


