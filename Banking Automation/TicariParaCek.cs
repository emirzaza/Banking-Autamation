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
    public partial class TicariParaCek : Form
    {
        public TicariParaCek()
        {
            InitializeComponent();
        }

        public static int miktar;
        public static int hesapno;
        public static int toplam = 0;
        private void btnCekticari_Click(object sender, EventArgs e)
        {

            clstiicarihesap form2 = new clstiicarihesap();

            miktar = Convert.ToInt32(txtticariparacekmiktar.Text);
            hesapno = Convert.ToInt32(txtticariparacekhesapno.Text);
            toplam += Convert.ToInt32(txtticariparacekmiktar.Text);

            clstiicarihesap hsp = new clstiicarihesap();

            hsp.ParaCek();
            this.Close();
        }
    }
}
