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
    public partial class TicariHesap : Form
    {
        public TicariHesap()
        {
            InitializeComponent();
        }

        int number = GirisYap.Dataticari;

        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

        public void tablogoster(string txt)
        {


            baglantı.Open();

            NpgsqlCommand komut = new NpgsqlCommand();

            komut.Connection = baglantı;

            komut.CommandType = CommandType.Text;

            komut.CommandText = txt;
            komut.Parameters.AddWithValue("@hangi_no", number);
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                ticarianasayfa.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }
        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariParaCek ticariParaCek = new TicariParaCek();
            ticariParaCek.Show();
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariParaYatir ticariParaYatir = new TicariParaYatir();
            ticariParaYatir.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariHavale ticariHavale = new TicariHavale();
            ticariHavale.Show();
        }

        private void btnHesapEkleTicari_Click(object sender, EventArgs e)
        {
            TicariHesapEkle ticariHesapEkle = new TicariHesapEkle();
            ticariHesapEkle.Show();
        }

        private void btnHesapSilTicari_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Bakiyeniz 0 değilse sil tuşuna bassanız bile hesabınız otomatik olarak silinmeyecektir. Hesap silme işlemini başarı ile tamamlayabilmek için önce lütfen hesap içindeki tüm bakiyeyi başka bir hesabınıza aktarın! Eğer bakiyeniz eksi ise lütfen borçlarını kapatınız");
            TicariHesapSil ticariHesapSil = new TicariHesapSil();
            ticariHesapSil.Show();
        }

        private void btnhesapgösterticari_Click(object sender, EventArgs e)
        {
            tablogoster("select * from hesap where musterino=@hangi_no");
        }

        private void ticariDökümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariDokum ticariDokum = new TicariDokum();    
            ticariDokum.Show(); 
        }
    }
}
