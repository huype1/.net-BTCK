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
    public partial class frmTimKiem1 : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public frmTimKiem1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dta = new DataTable();
            string sqlts = ""; 
            sqlts = string.Format("EXECUTE TimKiemChamCongTheoThang '{0}', '{0}'", textBox1.Text, textBox3.Text);
            dta = kn.Lay_DuLieu(sqlts);

            dataGridView1.DataSource = dta;
        }

        private void frmTimKiem1_Load(object sender, EventArgs e)
        {
            try
            {
                kn.KetNoi_DuLieu();
                string currentDatabase = kn.cnn.Database;
                string serverName = kn.cnn.DataSource;
                kn.HuyKetNoi_DuLieu();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
