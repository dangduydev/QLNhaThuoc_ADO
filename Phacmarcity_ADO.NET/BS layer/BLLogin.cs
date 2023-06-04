using Phacmarcity_ADO.NET.Class;
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
        public bool KiemTraDangNhap(string Username, string Password)
        {
            string connectionString = "Data Source=(local);Initial Catalog=QLNhaThuoc;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MatKhau, BoPhan FROM TaiKhoan INNER JOIN NhanVien ON TaiKhoan.MaNhanVien = NhanVien.MaNhanVien WHERE TaiKhoan.MaNhanVien = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString(0);
                            string department = reader.GetString(1);

                            if (Password == storedPassword)
                            {
                                // Đăng nhập thành công
                                if (department == "Quản lý")
                                {
                                    AppSettings.flag_role = true;
                                }
                                else
                                {
                                    AppSettings.flag_role = false;
                                }

                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }


    }
}


