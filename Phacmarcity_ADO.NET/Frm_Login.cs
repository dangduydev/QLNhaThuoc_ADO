using Phacmarcity_ADO.NET.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                BLLogin blLogin = new BLLogin();
                bool check_Login = blLogin.KiemTraDangNhap(txtUsername.Text, txtPass.Text);
                if (check_Login)
                {
                    isLoggedIn = true;
                    Form f = new Frm_Home();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    break;
                    /*                    // Yêu cầu người dùng nhập lại thông tin đăng nhập
                                        DialogResult result = MessageBox.Show("Bạn có muốn đăng nhập lại không?", "Đăng nhập lại", MessageBoxButtons.YesNo);
                                        if (result == DialogResult.No)
                                        {
                                            break;
                                        }*/
                }
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
