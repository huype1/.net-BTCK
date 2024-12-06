using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCC
{
    public partial class FrmDangNhap : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_DuLieu();
            string dn = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string sql_login;
            sql_login = "SELECT TENDN, MATKHAU FROM HETHONG WHERE TENDN='" + dn + "' AND MATKHAU = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read())
            {
                MessageBox.Show("Dang nhap thanh cong");
                MDI_QLCC menu = new MDI_QLCC();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Ten tai khoan hoac mat khau sai, hay thu lai");
            }
        }
    }
}
