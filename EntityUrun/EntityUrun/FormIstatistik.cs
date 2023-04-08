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
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }
        EntityUrunEntities1 db= new EntityUrunEntities1();
        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Table_Kategori.Count().ToString();
            label3.Text = db.Table_Urun.Count().ToString();
            label5.Text = db.Table_Musteri.Count(X=> X.MusteriDurum == true).ToString();
            label7.Text = db.Table_Musteri.Count(X => X.MusteriDurum == false).ToString();
            label13.Text = db.Table_Urun.Sum(y=>y.UrunStokSayisi).ToString();
            label21.Text= db.Table_Satis.Sum(Z => Z.SatisFiyat).ToString() + "TL";
            label11.Text = (from a in db.Table_Urun orderby a.UrunSatisFiyati descending select a.UrunAd).FirstOrDefault();
            label9.Text = (from a in db.Table_Urun orderby a.UrunSatisFiyati ascending select a.UrunAd).FirstOrDefault();
            label15.Text = db.Table_Urun.Count(x=>x.UrunKategoriId == 1).ToString();
            label17.Text =db.Table_Urun.Count(x=>x.UrunAd == "Buzdolabı").ToString();
            label23.Text = (from x in db.Table_Musteri select x.MusteriSehir).Distinct().Count().ToString();
            label19.Text = db.MarkaGetir().FirstOrDefault();
        }
    }
}
