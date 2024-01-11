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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Hayvan Hayvan { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtID)) return;
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtTur)) return;
            if (!ErrorControl(txtCins)) return;
            if (!ErrorControl(txtRenk)) return;
            if (!ErrorControl(txtDogum)) return;
            if (!ErrorControl(txtTC)) return;

            Hayvan.ID = txtID.Text;
            Hayvan.Ad = txtAd.Text;
            Hayvan.Tur = txtTur.Text;
            Hayvan.Cins = txtCins.Text;
            Hayvan.Renk = txtRenk.Text;
            Hayvan.Dogum = txtDogum.Text;
            Hayvan.TC = txtTC.Text;


            DialogResult =DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");   
                    return true;

                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                Hayvan.ID = txtID.Text;
                Hayvan.Ad = txtAd.Text;
                Hayvan.Tur = txtTur.Text;
                Hayvan.Cins = txtCins.Text;
                Hayvan.Renk = txtRenk.Text;
                Hayvan.Dogum = txtDogum.Text;
                Hayvan.TC = txtTC.Text;

            }


        }
    }
}
