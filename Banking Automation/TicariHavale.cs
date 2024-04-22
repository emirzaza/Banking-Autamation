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
    public partial class TicariHavale : Form
    {
        public TicariHavale()
        {
            InitializeComponent();
        }

        public static int miktar;
        public static int hesapnover;
        public static int hesapnoal;
        private void btnTicariHavale_Click(object sender, EventArgs e)
        {

            miktar = Convert.ToInt32(txtticarihavalemiktar.Text);
            hesapnoal = Convert.ToInt32(txtticarihavalealıcıhesapno.Text);
            hesapnover = Convert.ToInt32(txtticarihavalevericino.Text);

            clstiicarihesap hsp = new clstiicarihesap();

            hsp.Havale();






            this.Close();
        }
    }
}
