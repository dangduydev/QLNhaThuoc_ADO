using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLHangSX
    {       
            DBMain db = null;

            public BLHangSX()
            {
                db = new DBMain();
            }
            public DataSet LayHangSX()
            {
                return db.ExecuteQueryDataSet("select * from HangSX", CommandType.Text);
            }
            public DataSet TimKiemHangSX(string input, string key)
            {
                return db.ExecuteQueryDataSet("select * from HangSX Where " + input + " like '%" + key + "%'", CommandType.Text);
            }
            public bool ThemHangSX(string MaHangSX, string TenHang, string QuocGia, ref string err)
            {
                string sqlString = "Insert Into HangSX Values('" +
                MaHangSX + "', N'" +
                TenHang + "', N'" + QuocGia + "')";

                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

            }
            public bool XoaHangSX(ref string err, string MaHangSX)
            {
                string sqlString = "Delete From HangSX Where MaHangSX='" + MaHangSX + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
            public bool CapNhatHangSX(string MaHangSX, string TenHang, string QuocGia, ref string err)
            {
                string sqlString = "Update HangSX Set TenHang=N'" +
                TenHang + "', QuocGia= N'" + QuocGia + "' Where MaHangSX='" + MaHangSX + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            }
        }
    }


