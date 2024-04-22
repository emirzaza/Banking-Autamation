using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne1._0
{
    internal class clstiicarihesap: Hesap
    {

        int miktarcek = TicariParaCek.miktar;
        int hesapnocek = TicariParaCek.hesapno;
        int toplam = TicariParaCek.toplam;

        int miktar = TicariParaYatir.miktar;
        int hesapno = TicariParaYatir.hesapno;


        int miktarhav = TicariHavale.miktar;
        int alıcıno = TicariHavale.hesapnoal;
        int vericino = TicariHavale.hesapnover;
        public override void ParaCek()
        {
            if (toplam <= 750)
            {
                NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");

                baglantı.Open();
                NpgsqlCommand komut_yatır = new NpgsqlCommand();
                komut_yatır.Connection = baglantı;

                int bakiye = 0;

                komut_yatır.CommandText = "SELECT bakiye FROM hesap WHERE hesapno = @hangi_hesapno";
                komut_yatır.Parameters.AddWithValue("@hangi_hesapno", hesapnocek);

                using (NpgsqlDataReader oku = komut_yatır.ExecuteReader())
                {
                    if (oku.Read())
                    {
                        bakiye = Convert.ToInt32(oku["bakiye"]);
                        bakiye = bakiye - miktarcek;

                    }


                    oku.Close();


                    komut_yatır.Parameters.Clear();

                    komut_yatır.Parameters.AddWithValue("@hangi_hesapno", hesapnocek);
                    komut_yatır.Parameters.AddWithValue("@kacpara", bakiye);

                    komut_yatır.CommandType = CommandType.Text;
                    komut_yatır.CommandText = "UPDATE hesap SET bakiye = @kacpara WHERE hesapno = @hangi_hesapno";
                    komut_yatır.ExecuteNonQuery();

                    komut_yatır.Dispose();
                    baglantı.Close();

                    NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=dokum;User Id=postgres;Password=1234;Database=postgres");


                    bireyselbaglantı.Open();
                    NpgsqlCommand komut_ekle = new NpgsqlCommand();
                    komut_ekle.Connection = bireyselbaglantı;
                    miktar = miktar - (miktar * 2);

                    komut_ekle.Parameters.AddWithValue("@NO", hesapnocek);
                    komut_ekle.Parameters.AddWithValue("@DOKUM", miktarcek.ToString() + "   tl Çekildi  " + DateTime.Now);



                    komut_ekle.CommandType = CommandType.Text;
                    komut_ekle.CommandText = "insert into dokum values (@NO, @DOKUM)";
                    _ = komut_ekle.ExecuteReader();

                    komut_ekle.Dispose();
                    bireyselbaglantı.Close();


                }
            }
            else
            {
                int kalan = 750 - toplam;

                MessageBox.Show("Limit Aşımı! Günlük Çekileilcek miktarı geçiyorsunuz. Lütfen " + kalan + " tl daha az bir miktar çekin.");
            }

           
        }

        public override void ParaYatir()
        {
            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");

            baglantı.Open();
            NpgsqlCommand komut_yatır = new NpgsqlCommand();
            komut_yatır.Connection = baglantı;

            int bakiye = 0;

            komut_yatır.CommandText = "SELECT bakiye FROM hesap WHERE hesapno = @hangi_hesapno";
            komut_yatır.Parameters.AddWithValue("@hangi_hesapno", hesapno);

            using (NpgsqlDataReader oku = komut_yatır.ExecuteReader())
            {
                if (oku.Read())
                {
                    bakiye = Convert.ToInt32(oku["bakiye"]);
                    bakiye = bakiye + miktar;
                }

                
                oku.Close();

             
                komut_yatır.Parameters.Clear();

                komut_yatır.Parameters.AddWithValue("@hangi_hesapno", hesapno);
                komut_yatır.Parameters.AddWithValue("@kacpara", bakiye);

                komut_yatır.CommandType = CommandType.Text;
                komut_yatır.CommandText = "UPDATE hesap SET bakiye = @kacpara WHERE hesapno = @hangi_hesapno";
                komut_yatır.ExecuteNonQuery();

                komut_yatır.Dispose();
                baglantı.Close();

                NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=dokum;User Id=postgres;Password=1234;Database=postgres");


                bireyselbaglantı.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = bireyselbaglantı;


                komut_ekle.Parameters.AddWithValue("@NO", hesapno);
                komut_ekle.Parameters.AddWithValue("@DOKUM", miktar.ToString() + "   tl yatırıldı  " + DateTime.Now);



                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into dokum values (@NO, @DOKUM)";
                _ = komut_ekle.ExecuteReader();

                komut_ekle.Dispose();
                bireyselbaglantı.Close();
            }
        }

        public override void Havale()
        {

            NpgsqlConnection baglantı1 = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

            baglantı1.Open();
            NpgsqlCommand komut_cek = new NpgsqlCommand();
            komut_cek.Connection = baglantı1;

            int bakiye1 = 0;

            komut_cek.CommandText = "SELECT bakiye FROM hesap WHERE hesapno = @hangi_hesapno";
            komut_cek.Parameters.AddWithValue("@hangi_hesapno", vericino);

            using (NpgsqlDataReader oku = komut_cek.ExecuteReader())
            {
                if (oku.Read())
                {
                    bakiye1 = Convert.ToInt32(oku["bakiye"]);
                    bakiye1 = bakiye1 - miktarhav;
                    

                }


                oku.Close();


                komut_cek.Parameters.Clear();

                komut_cek.Parameters.AddWithValue("@hangi_hesapno", vericino);
                komut_cek.Parameters.AddWithValue("@kacpara", bakiye1);

                komut_cek.CommandType = CommandType.Text;
                komut_cek.CommandText = "UPDATE hesap SET bakiye = @kacpara WHERE hesapno = @hangi_hesapno";
                komut_cek.ExecuteNonQuery();

                komut_cek.Dispose();
                baglantı1.Close();



                NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hesap;User Id=postgres;Password=1234;Database=postgres");

                baglantı.Open();
                NpgsqlCommand komut_yatır = new NpgsqlCommand();
                komut_yatır.Connection = baglantı;

                int bakiye = 0;

                komut_yatır.CommandText = "SELECT bakiye FROM hesap WHERE hesapno = @hangi_hesapno";
                komut_yatır.Parameters.AddWithValue("@hangi_hesapno", alıcıno);

                using (NpgsqlDataReader oku1 = komut_yatır.ExecuteReader())
                {
                    if (oku1.Read())
                    {
                        bakiye = Convert.ToInt32(oku["bakiye"]);
                        bakiye = bakiye + miktarhav;
                    }


                    oku.Close();


                    komut_yatır.Parameters.Clear();

                    komut_yatır.Parameters.AddWithValue("@hangi_hesapno", alıcıno);
                    komut_yatır.Parameters.AddWithValue("@kacpara", bakiye);

                    komut_yatır.CommandType = CommandType.Text;
                    komut_yatır.CommandText = "UPDATE hesap SET bakiye = @kacpara WHERE hesapno = @hangi_hesapno";
                    komut_yatır.ExecuteNonQuery();

                    komut_yatır.Dispose();
                    baglantı.Close();

                    NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=dokum;User Id=postgres;Password=1234;Database=postgres");


                    bireyselbaglantı.Open();
                    NpgsqlCommand komut_ekle = new NpgsqlCommand();
                    komut_ekle.Connection = bireyselbaglantı;


                    komut_ekle.Parameters.AddWithValue("@NO", vericino);
                    komut_ekle.Parameters.AddWithValue("@DOKUM", miktarhav.ToString() + "  tl " + alıcıno + " numaralı  hesaba havale edildi" + "" + DateTime.Now);



                    komut_ekle.CommandType = CommandType.Text;
                    komut_ekle.CommandText = "insert into dokum values (@NO, @DOKUM)";
                    _ = komut_ekle.ExecuteReader();

                    komut_ekle.Dispose();
                    bireyselbaglantı.Close();

                    NpgsqlConnection bireyselbaglantı2 = new NpgsqlConnection("Server=localhost; Port=5432;Database=dokum;User Id=postgres;Password=1234;Database=postgres");


                    bireyselbaglantı2.Open();
                    NpgsqlCommand komut_ekle2 = new NpgsqlCommand();
                    komut_ekle2.Connection = bireyselbaglantı2;


                    komut_ekle2.Parameters.AddWithValue("@NO", alıcıno);
                    komut_ekle2.Parameters.AddWithValue("@DOKUM", miktarhav.ToString() + "  tl " + vericino + " hesabı tarafından havale alındı  " + "" + DateTime.Now);



                    komut_ekle2.CommandType = CommandType.Text;
                    komut_ekle2.CommandText = "insert into dokum values (@NO, @DOKUM)";
                    _ = komut_ekle2.ExecuteReader();

                    komut_ekle2.Dispose();
                    bireyselbaglantı2.Close();



                }


            }
        }

    }
}
