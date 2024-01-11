using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace ABCSpot.UI
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public Sahip Sahip { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txttici)) return;
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtNumara)) return;

            Sahip.TC = txttici.Text;
            Sahip.Ad = txtisim.Text;
            Sahip.Soyad = txtsoyisim.Text;
            Sahip.Numara = txtnum.Text;
            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
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

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                Sahip.TC = txttici.Text;
                Sahip.Ad = txtisim.Text;
                Sahip.Soyad = txtsoyisim.Text;
                Sahip.Numara = txtnum.Text;
            }
        }
    }
}
