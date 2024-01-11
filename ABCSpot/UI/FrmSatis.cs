using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCSpot.UI
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public Randevular Randevular { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {

            Randevular.randevuid = textBox2.Text;
            Randevular.hayvanid = txtMusteri.Text;
            Randevular.vetid = textBox3.Text;
            Randevular.tarihsaatid = textBox1.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                Randevular.randevuid = textBox2.Text;
                txtMusteri.Text = Randevular.hayvanid.ToString();
                Randevular.vetid = textBox3.Text;
                Randevular.tarihsaatid = textBox1.Text;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Hayvan.ID.ToString ();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.Sahip.TC.ToString();
            }
        }
    }
}
