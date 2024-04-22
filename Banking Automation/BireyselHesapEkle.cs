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
    public partial class BireyselHesapEkle : Form
    {
        public BireyselHesapEkle()
        {
            InitializeComponent();
        }

        int number = GirisYap.Data;
        private void btnonaybireysel_Click(object sender, EventArgs e)
        {
            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

            Hesap acc = new Hesap();

            List<int> nolar = new List<int>();
            Random rst = new Random();
            int rstsayi = rst.Next();
            if (!nolar.Contains(rstsayi))
                nolar.Add(rstsayi);

            acc.HesapNO = Convert.ToInt32(rstsayi);
            acc.Bakiye = 0;

            bireyselbaglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = bireyselbaglantı;

            komut_ekle.Parameters.AddWithValue("@M_NO",number);
            komut_ekle.Parameters.AddWithValue("@H_NO", acc.HesapNO);
            komut_ekle.Parameters.AddWithValue("@BAKIYE", acc.Bakiye);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hesap (musterino, hesapno, bakiye ) values (@M_NO, @H_NO, @BAKIYE)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            bireyselbaglantı.Close();

            MessageBox.Show("HESAP OLUŞTURULDU HESAP NUMARANIZ: " + acc.HesapNO);

            

            this.Close();
        }
    }
}
