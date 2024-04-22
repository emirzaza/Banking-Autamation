using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne1._0
{
    internal class Musteri
    {

        public int MusteriNo { get; set; }

        public string Ad { get; set; }

        public string Sifre { get; set; }

        public string Mail { get; set; }

        public long TelNo { get; set; }
        public string MusteriTip { get; set; }
        public List<Hesap> BireyselHesaplar { get; set; } = new List<Hesap>();
        public List<Hesap> TicariHesaplar { get; set; } = new List<Hesap>();


        public virtual void HesapAcma(Hesap Account)
        {
        }

        public virtual void HesapKapatma(Hesap Account)
        {

        }

        public void ParaCek()
        {
            //todo
        }

        public void ParaYatır()
        {
            //todo
        }

        public  virtual void HavaleYap()
        {
            //todo
        }

        public void HavaleAl()
        {
            //todo
        }


    }
}
