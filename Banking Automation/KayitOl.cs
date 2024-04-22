using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Nesne1._0
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btnBireyselKayitOl_Click(object sender, EventArgs e)
        {

            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=bireyselmusteri;User Id=postgres;Password=1234;Database=postgres");


            Banka bank = new Banka();
            BireyselMusteri Müsteri = new BireyselMusteri();

            Müsteri.Ad = txtBireyselAd.Text;
            Müsteri.Soyad = txtBireyselSoyAd.Text;
            Müsteri.Yas= Convert.ToInt64(txtBireyselYas.Text);
            Müsteri.Mail = txtBireyselMail.Text;
            Müsteri.Sifre = txtBireyselSifre.Text;
            Müsteri.TelNo = Convert.ToInt64(txtBireyselTelefonNo.Text);
            Müsteri.MusteriTip = "Bireysel";

            List<int> nolar = new List<int>();
            Random rst = new Random();
            int rstsayi = rst.Next();
            if (!nolar.Contains(rstsayi))
                nolar.Add(rstsayi);

            Müsteri.MusteriNo = Convert.ToInt32(rstsayi);

            bireyselbaglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = bireyselbaglantı;

            komut_ekle.Parameters.AddWithValue("@NO", Müsteri.MusteriNo);
            komut_ekle.Parameters.AddWithValue("@AD", Müsteri.Ad);
            komut_ekle.Parameters.AddWithValue("@SOYAD", Müsteri.Soyad);
            komut_ekle.Parameters.AddWithValue("@YAS", Müsteri.Yas);
            komut_ekle.Parameters.AddWithValue("@MAIL", Müsteri.Mail);
            komut_ekle.Parameters.AddWithValue("@SIFRE", Müsteri.Sifre);
            komut_ekle.Parameters.AddWithValue("@TELNO",Müsteri.TelNo);
           

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into bireyselmusteri (musterino, adi, soyadi, yas,email, sifre,telno) values (@NO, @AD, @SOYAD, @YAS, @MAIL, @SIFRE, @TELNO)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            bireyselbaglantı.Close();

            MessageBox.Show(" musteri numaranız:"+ rstsayi);
            
            this.Close();
        }



        private void btnTicariKayitOl_Click(object sender, EventArgs e)
        {
            NpgsqlConnection ticaribaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ticarimusteri;User Id=postgres;Password=1234;Database=postgres");

            Banka bank = new Banka();
            TicariMusteri Müsteri = new TicariMusteri();

            Müsteri.Ad = txtTicariAd.Text;
            Müsteri.Adres = txtTicariKonum.Text;
            Müsteri.Mail = txtTicariMail.Text;
            Müsteri.Sifre = txtTicariSifre.Text;
            Müsteri.TelNo = Convert.ToInt64(txtTicariTelefon.Text);
            Müsteri.MusteriTip = "TİCARİ";

            List<int> nolar = new List<int>();
            Random rst = new Random();
            int rstsayi = rst.Next();
            if (!nolar.Contains(rstsayi))
                nolar.Add(rstsayi);

            Müsteri.MusteriNo = Convert.ToInt32(rstsayi);

            ticaribaglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection =ticaribaglantı;

            komut_ekle.Parameters.AddWithValue("@NO", Müsteri.MusteriNo);
            komut_ekle.Parameters.AddWithValue("@AD", Müsteri.Ad);
            komut_ekle.Parameters.AddWithValue("@ADRES", Müsteri.Adres);
            komut_ekle.Parameters.AddWithValue("@MAIL", Müsteri.Mail);
            komut_ekle.Parameters.AddWithValue("@SIFRE", Müsteri.Sifre);
            komut_ekle.Parameters.AddWithValue("@TELNO", Müsteri.TelNo);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ticarimusteri (musterino, adi, adres,email, sifre,telno) values (@NO, @AD, @ADRES, @MAIL, @SIFRE, @TELNO)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            ticaribaglantı.Close();

            MessageBox.Show(" musteri numaranız:" + rstsayi);

            this.Close();
        }

        
    }
}
