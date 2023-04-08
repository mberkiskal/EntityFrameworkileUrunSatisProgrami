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
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FormUrun fr = new FormUrun();
            fr.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
