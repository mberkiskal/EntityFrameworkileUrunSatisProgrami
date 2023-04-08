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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EntityUrunEntities1 db = new EntityUrunEntities1();

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler= db.Table_Kategori.ToList();
            dataGridView1.DataSource= kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Table_Kategori t = new Table_Kategori();
            t.KategoriAd=textBox2.Text;
            db.Table_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(textBox1.Text);
            var kategori = db.Table_Kategori.Find(x);
            db.Table_Kategori.Remove(kategori); 
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi!");
        }

        private void bgnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kategori = db.Table_Kategori.Find(x);
            kategori.KategoriAd = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
