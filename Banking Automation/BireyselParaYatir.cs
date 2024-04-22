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
    public partial class BireyselParaYatir : Form
    {
        public BireyselParaYatir()
        {
            InitializeComponent();
        }

        public static int miktar;
        public static int hesapno;
        private void btnBireyselParaCek_Click(object sender, EventArgs e)
        {
          clsbireyselhesap form2 = new clsbireyselhesap();

            miktar = Convert.ToInt32(txtyatırılanparabireysel.Text);
           hesapno = Convert.ToInt32(txthesapnoparayatır.Text);


            clsbireyselhesap hsp = new clsbireyselhesap();

            hsp.ParaYatir();



            this.Close();
        }
    }
}
