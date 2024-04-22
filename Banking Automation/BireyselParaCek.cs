using System;
using System.Windows.Forms;

namespace Nesne1._0
{
    public partial class BireyselParaCek : Form
    {
        public BireyselParaCek()
        {
            InitializeComponent();
        }

        public static int miktar;
        public static int hesapno;
        public static int toplam=0;
        private void btnCek_Click(object sender, EventArgs e)
        {

            clsbireyselhesap form2 = new clsbireyselhesap();

            miktar = Convert.ToInt32(txtbireyselparacekmiktar.Text);
            hesapno = Convert.ToInt32(txtbireyselparacekhesapno.Text);
            toplam += Convert.ToInt32(txtbireyselparacekmiktar.Text);  
            
            clsbireyselhesap hsp = new clsbireyselhesap();

            hsp.ParaCek();

            this.Close();
        }
    }
}
