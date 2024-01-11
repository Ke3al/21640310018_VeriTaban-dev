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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public SaglikGecmisi SaglikGecmisi { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {

            SaglikGecmisi.gecmisid = textBox1.Text;
            SaglikGecmisi.hayvanid = txtMusteri.Text;
            SaglikGecmisi.vetid = textBox3.Text;
            SaglikGecmisi.tarihsaatid = textBox4.Text;
            SaglikGecmisi.tani = textBox2.Text;
            SaglikGecmisi.tedavi = txtAciklama.Text;


            DialogResult = DialogResult.OK;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                SaglikGecmisi.gecmisid = textBox1.Text;
                txtMusteri.Text = SaglikGecmisi.hayvanid.ToString();
                SaglikGecmisi.vetid=textBox3.Text;
                SaglikGecmisi.tarihsaatid = textBox4.Text;
                SaglikGecmisi.tani = textBox2.Text;
                SaglikGecmisi.tedavi = txtAciklama.Text;
            }

        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Hayvan.ID.ToString();
            }
        }
    }
}
