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
    public class Hesap
    {
        public int HesapNO { get; set; }

        public int Bakiye { get; set; }

        public virtual void ParaCek()
        {
         
        }

      public virtual void ParaYatir()
        {

        }
    


        public virtual void Havale()
        {

        }
        public void HesapOzeti()
            {

            }
        }
    } 
