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
    public partial class FrmNhanVien : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("SELECT * FROM NHANVIEN ORDER BY MANV");
            dataGridNV.DataSource = dta;
        }
        public void BangDonVi()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("SELECT * FROM DONVI ORDER BY MADV");
            cboMaDV.DataSource = dta;
            cboMaDV.DisplayMember = "MaDV";
        }
        public void BangChucVu()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("SELECT * FROM CHUCVU ORDER BY MACV");
            cboMaCV.DataSource = dta;
            cboMaCV.DisplayMember = "MACV";
        }
        public void HienThiDuLieu()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataGridNV.DataSource, "MANV");


            cboMaDV.DataBindings.Clear();
            cboMaDV.DataBindings.Add("Text", dataGridNV.DataSource, "MADV");


            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataGridNV.DataSource, "HOTEN");


            dateNgSinh.DataBindings.Clear();
            dateNgSinh.DataBindings.Add("Text", dataGridNV.DataSource, "NGAYSINH");


            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");


            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridNV.DataSource, "DIACHI");


            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dataGridNV.DataSource, "DIENTHOAI");


            cboMaCV.DataBindings.Clear();
            cboMaCV.DataBindings.Add("Text", dataGridNV.DataSource, "MACV");
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            BangNhanVien();
            BangChucVu();
            BangDonVi();
            HienThiDuLieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaNV.DataBindings.Clear();
            cboMaDV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dateNgSinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            cboMaCV.DataBindings.Clear();

            txtMaNV.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NHANVIEN VALUES(" +
                "'" + txtMaNV.Text + "', " +
                "'" + cboMaDV.Text + "', " +
                "'" + txtHoTen.Text + "', " +
                "'" + dateNgSinh.Text + "', " +
                "'" + cboGioiTinh.Text + "', " +
                "'" + txtDiaChi.Text + "', " +
                "'" + txtDienThoai.Text + "', " +
                "'" + cboMaCV.Text + "')";

            kn.ThucThi(sql);
            BangNhanVien();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "UPDATE NHANVIEN SET ";
            sql_sua += "MADV = '" + cboMaDV.Text + "', ";
            sql_sua += "HOTEN = '" + txtHoTen.Text + "', ";
            sql_sua += "NGAYSINH = '" + dateNgSinh.Text + "', ";
            sql_sua += "GIOITINH = '" + cboGioiTinh.Text + "', ";
            sql_sua += "DIACHI = '" + txtDiaChi.Text + "', ";
            sql_sua += "DIENTHOAI = '" + txtDienThoai.Text + "', ";
            sql_sua += "MACV = '" + cboMaCV.Text + "' ";
            sql_sua += "WHERE MANV = '" + txtMaNV.Text + "'";

            kn.ThucThi(sql_sua);
            BangNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa du lieu nay khong? ", "Thong bao",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (thongbao == DialogResult.OK)
            {
                string sql_xoa = "DELETE FROM NHANVIEN WHERE MANV = MaNV";

                kn.ThucThi(sql_xoa);
                BangNhanVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
