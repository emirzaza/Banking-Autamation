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
    public partial class BireyselDokum : Form
    {
        public BireyselDokum()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=dokum;User Id=postgres;Password=1234;Database=postgres");
        public void tablogoster(string txt)
        {
         



                baglantı.Open();

                NpgsqlCommand komut = new NpgsqlCommand();

                komut.Connection = baglantı;

                komut.CommandType = CommandType.Text;

                komut.CommandText = txt;

                komut.Parameters.AddWithValue("@hangi_no", Convert.ToInt64(txtdokumbireysel.Text));

                NpgsqlDataReader dr = komut.ExecuteReader();

                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    gridbireyseldokum.DataSource = dt;


                }
                komut.Dispose();
                baglantı.Close();
            
        }

        private void BireyselDokum_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbireyseldokum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdokumbireysel.Text))
            {
                MessageBox.Show("Lütfen bir hesap numarası giriniz!");
            }
            else
            {
                tablogoster("select miktar from dokum where hesapno = @hangi_no ");
            }
          
        }
    }
}
