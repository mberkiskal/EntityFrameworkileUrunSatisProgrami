using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityUrun
{
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }
        EntityUrunEntities1 db = new EntityUrunEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Table_Urun
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.UrunMarkas,
                                            x.UrunStokSayisi,
                                            x.UrunSatisFiyati,
                                            x.Table_Kategori.KategoriAd,
                                            x.UrunDurum

                                        }).ToList();
                                        
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Table_Urun t = new Table_Urun();
            t.UrunAd = txtUrunAd.Text;
            t.UrunMarkas= txtUrunMarka.Text;
            t.UrunStokSayisi =short.Parse(txtUrunStok.Text);
            t.UrunKategoriId = int.Parse(cmbUrunKategori.SelectedValue.ToString());
            t.UrunSatisFiyati= decimal.Parse(txtUrunFiyat.Text);
            t.UrunDurum = true;
            db.Table_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtUrunId.Text);
            var urun = db.Table_Urun.Find(x);
            db.Table_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistemden Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtUrunId.Text);
            var urun = db.Table_Urun.Find(x);
            urun.UrunAd= txtUrunAd.Text;
            urun.UrunMarkas = txtUrunMarka.Text;
            urun.UrunStokSayisi = short.Parse(txtUrunStok.Text);
            urun.UrunKategoriId = int.Parse(cmbUrunKategori.Text);
            urun.UrunSatisFiyati = decimal.Parse(txtUrunFiyat.Text);
            urun.UrunDurum = true;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi!");
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            var kategoriler =(from x in db.Table_Kategori
                              select new
                              {
                                  x.KategoriId,
                                  x.KategoriAd
                              }
                              ).ToList();
            cmbUrunKategori.ValueMember = "KategoriId";
            cmbUrunKategori.DisplayMember = "KategoriAd";
            cmbUrunKategori.DataSource= kategoriler;
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = cmbUrunKategori.SelectedValue.ToString();

           // txtUrunAd.Text ="";
            txtUrunDurum.Text = "";
            txtUrunFiyat.Text = "";
            txtUrunId.Text = "";
            txtUrunMarka.Text = "";
            txtUrunStok.Text = "";
        }
       
    }
}
