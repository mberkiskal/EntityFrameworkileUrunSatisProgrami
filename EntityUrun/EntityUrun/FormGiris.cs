using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrun
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        EntityUrunEntities1 db=new EntityUrunEntities1();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu= from x in db.Table_Admin where x.AdminKullaniciAd == txtKullanici.Text && x.AdminSifre == txtSifre.Text select x;
            if(sorgu.Any() )
            {
                FormAnaForm ana = new FormAnaForm();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre!");
            }
        }
    }
}
