using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne1._0
{
    public partial class TicariHesapSil : Form
    {
        public TicariHesapSil()
        {
            InitializeComponent();
        }

        private void btnHesapSilOnayTicari_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

            baglantı.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = baglantı;
            komut_sil.Parameters.AddWithValue("@hangi_hesap", Convert.ToInt32(txtticarihesapsil.Text));

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete  from hesap where hesapno = @hangi_hesap and bakiye=0";

            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                ticarihesapsiltablo.DataSource = dt;
            }

            komut_sil.Dispose();
            baglantı.Close();

            this.Close();
        }
    }
}
