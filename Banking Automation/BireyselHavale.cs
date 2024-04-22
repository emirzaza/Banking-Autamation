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
    public partial class BireyselHavale : Form
    {
        public BireyselHavale()
        {
            InitializeComponent();
            MessageBox.Show("Bilgilendirme: Yapılan İşlemden %2 havale ücreti kesilecektir.");
        }

        public static int miktar;
        public static int hesapnover;
        public static int hesapnoal;
        private void btnBireyselHavale_Click(object sender, EventArgs e)
        {

            clsbireyselhesap form2 = new clsbireyselhesap();

            miktar = Convert.ToInt32(txtbireyselhavalemiktar.Text);
            hesapnoal = Convert.ToInt32(txtbireyselhavalealıcı.Text);
            hesapnover = Convert.ToInt32(txtbireyselhavalegönderici.Text);


            clsbireyselhesap hsp = new clsbireyselhesap();

            hsp.Havale();

            this.Close();
        }
    }
}
