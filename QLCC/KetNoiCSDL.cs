using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCC
{
    internal class KetNoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
        public void KetNoi_DuLieu()
        {
            string strKetNoi = @"Data Source=DESKTOP-JT61UOA;Initial Catalog=HovatenSV_MaSv;Integrated Security=True;TrustServerCertificate=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();

        }
        public void HuyKetNoi_DuLieu()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable Lay_DuLieu(string Sql)
        {
            KetNoi_DuLieu();

            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);

            return dta;
        }
        public void ThucThi(string sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi_DuLieu();
        }
    }
}
