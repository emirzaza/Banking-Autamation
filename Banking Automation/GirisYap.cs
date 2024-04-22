using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Nesne1._0
{
    public partial class GirisYap : Form
    {


        public GirisYap()
        {
            InitializeComponent();
           
            
        }


        public static int Data;
        private void btnBireyselGiris_Click(object sender, EventArgs e)
        {
            Data = Convert.ToInt32(txtbireyselgirisno.Text);
            BireyselHesap form2 = new BireyselHesap();
            BireyselHesapEkle form3 = new BireyselHesapEkle();
            TicariHesap form1 = new TicariHesap();
            TicariHesapEkle form4 = new TicariHesapEkle();


            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=bireyselmusteri;User Id=postgres;Password=1234;Database=postgres");


            bireyselbaglantı.Open();

            using (NpgsqlCommand komut = new NpgsqlCommand("SELECT sifre FROM bireyselmusteri WHERE musterino = @hangi_no", bireyselbaglantı))
            {
                komut.Parameters.AddWithValue("@hangi_no", Convert.ToInt32(txtbireyselgirisno.Text));

                using (NpgsqlDataReader oku = komut.ExecuteReader())
                {
                    if (oku.Read())
                    {
                        string password = oku["sifre"].ToString();

                        if (password == txtbireyselgirissifre.Text)
                        {
                            BireyselHesap bireyselHesap = new BireyselHesap();
                            bireyselHesap.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hata");
                        }

                    }
                }


            }




            bireyselbaglantı.Close();

            

    }

        public static int Dataticari;
        private void btnTicariGiris_Click(object sender, EventArgs e)
        {
            Dataticari = Convert.ToInt32(txtticarigirisno.Text);
          
            NpgsqlConnection ticaribaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ticarimusteri;User Id=postgres;Password=1234;Database=postgres");

            ticaribaglantı.Open();

            using (NpgsqlCommand komut = new NpgsqlCommand("SELECT sifre FROM ticarimusteri WHERE musterino = @hangi_no", ticaribaglantı))
            {
                komut.Parameters.AddWithValue("@hangi_no", Convert.ToInt32(txtticarigirisno.Text));

                using (NpgsqlDataReader oku = komut.ExecuteReader())
                {
                    if (oku.Read())
                    {
                        string password = oku["sifre"].ToString();

                        if (password == txtticarigirissifre.Text)
                        {
                            TicariHesap ticariHesap = new TicariHesap();
                            ticariHesap.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hata");
                        }

                    }
                   
                }
            }
        }
    }
}
