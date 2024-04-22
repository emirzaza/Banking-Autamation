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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
        }

        private void btnBankaDokumu_Click(object sender, EventArgs e)
        {
            BankaDokumu bankaDokumu = new BankaDokumu();
            bankaDokumu.Show();
        }

    }
}
