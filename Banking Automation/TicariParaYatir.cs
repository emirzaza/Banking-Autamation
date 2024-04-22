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
    public partial class TicariParaYatir : Form
    {
        public TicariParaYatir()
        {
            InitializeComponent();
        }
        public static int miktar;
        public static int hesapno;
        private void btnTicariParayatir_Click(object sender, EventArgs e)
        {

            clstiicarihesap form2 = new clstiicarihesap();

            miktar = Convert.ToInt32(txtticariparayatirmiktar.Text);
            hesapno = Convert.ToInt32(txtticariparayatirhesapno.Text);

            clstiicarihesap hsp = new clstiicarihesap();

            hsp.ParaYatir();



            this.Close();
        }
    }
}
