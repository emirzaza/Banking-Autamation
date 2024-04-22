using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne1._0
{
    public partial class BireyselHesap : Form
    {
        public BireyselHesap()
        {
            InitializeComponent();

            
        }

        int number = GirisYap.Data;

        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

        public void tablogoster(string txt)
        {
            

            baglantı.Open();

            NpgsqlCommand komut = new NpgsqlCommand();

            komut.Connection = baglantı;

            komut.CommandType = CommandType.Text;

            komut.CommandText = txt;
            komut.Parameters.AddWithValue("@hangi_no",number);
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                bireyselanasayfa.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }

        


        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselParaCek paraCek = new BireyselParaCek();
            paraCek.Show();
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselParaYatir paraYatir = new BireyselParaYatir();
            paraYatir.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselHavale bireyselHavale = new BireyselHavale();
            bireyselHavale.Show();
        }

        private void btnHesapEkleBireysel_Click(object sender, EventArgs e)
        {
            
            BireyselHesapEkle bireyselHesapEkle = new BireyselHesapEkle();
            bireyselHesapEkle.Show();
        }

        private void btnHesapSilBireysel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Bakiyeniz 0 değilse sil tuşuna bassanız bile hesabınız otomatik olarak silinmeyecektir. Hesap silme işlemini başarı ile tamamlayabilmek için önce lütfen hesap içindeki tüm bakiyeyi başka bir hesabınıza aktarın! Eğer bakiyeniz eksi ise lütfen borçlarını kapatınız");
            BireyselHesapSil bireyselHesapSil = new BireyselHesapSil();
            bireyselHesapSil.Show();
        }

        private void BireyselHesap_Load(object sender, EventArgs e)
        {

        }

        private void btnhesapgösterbireysel_Click(object sender, EventArgs e)
        {
           
            tablogoster("select * from hesap where musterino=@hangi_no");
        }

        private void bireyselanasayfa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesapDökümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselDokum bireyselDokum = new BireyselDokum();
            bireyselDokum.Show();   



        }





        }
    }

