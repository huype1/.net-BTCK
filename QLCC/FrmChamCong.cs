using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCC
{
    public partial class FrmChamCong : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmChamCong()
        {
            InitializeComponent();
        }
        public void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("SELECT * FROM NHANVIEN ORDER BY MANV");
            cboMaNV.DataSource = dta;
            cboMaNV.DisplayMember = "MaNV";
        }
        public void BangChamCong()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("SELECT * FROM CHAMCONG ORDER BY MANV");
            dataGridCV.DataSource = dta;
        }
        public void HienThiDuLieu()
        {
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("Text", dataGridCV.DataSource, "MANV");

            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", dataGridCV.DataSource, "THANG");

            txtNgayCong.DataBindings.Clear();
            txtNgayCong.DataBindings.Add("Text", dataGridCV.DataSource, "SONGAYCONG");

            txtNgayPhep.DataBindings.Clear();
            txtNgayPhep.DataBindings.Add("Text", dataGridCV.DataSource, "SONGAYPHEP");

            txtTienLuong.DataBindings.Clear();
            txtTienLuong.DataBindings.Add("Text", dataGridCV.DataSource, "TIENLUONG");
        }
        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO CHAMCONG VALUES ('" + cboMaNV.Text + "', '" + txtThang.Text + "', '" + txtNgayCong.Text + "', '" + txtNgayPhep.Text + "', '" + txtTienLuong.Text + "')";
            kn.ThucThi(sql1);
            BangChamCong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboMaNV.Text = "";
            txtThang.Text = "";
            txtNgayCong.Text = "";
            txtNgayPhep.Text = "";
            txtTienLuong.Text = "";

            cboMaNV.Focus();
        }

        private void FrmChamCong_Load(object sender, EventArgs e)
        {
            BangChamCong();
            BangNhanVien();
            HienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "UPDATE CHAMCONG SET THANG='" + txtThang.Text + "', ";
            sql_sua += "SONGAYCONG='" + txtNgayCong.Text + "', ";
            sql_sua += "SONGAYPHEP='" + txtNgayPhep.Text + "', ";
            sql_sua += "TIENLUONG='" + txtTienLuong.Text + "', ";
            sql_sua += "WHERE MANV='" + cboMaNV.Text + "', ";

            kn.ThucThi(sql_sua);
            BangChamCong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;

            thongbao = MessageBox.Show("Ban co muon xoa nguoi cham cong nay khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
            {
                string sql_xoa = "DELETE FROM CHAMCONG  WHERE MANV = '" + cboMaNV.Text + "'";
                kn.ThucThi(sql_xoa);
                BangChamCong();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon thoat khong? ", "Thong bao", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            
            if (thongbao == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
