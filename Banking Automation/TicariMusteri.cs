using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1._0
{
    internal class TicariMusteri:Musteri
    {
        public  string Adres { get; set; }

        public override void HavaleYap()
        {
         base.HavaleYap();
        }
    }
}
