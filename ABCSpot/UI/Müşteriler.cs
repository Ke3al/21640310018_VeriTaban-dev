using ABCSpot.BL;

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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Hayvan Ekle",
                Hayvan = new Hayvan(),
            };

        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.Hayvan);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Hayvan Güncelle",
                Güncelleme = true,
                Hayvan = new Hayvan()
                {
                    ID = row.Cells[0].Value.ToString(),
                    Ad = row.Cells[1].Value.ToString(),
                    Tur = row.Cells[2].Value.ToString(),
                    Cins = row.Cells[3].Value.ToString(),
                    Renk = row.Cells[4].Value.ToString(),
                    Dogum = row.Cells[5].Value.ToString(),
                    TC = row.Cells[5].Value.ToString()

                },
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Hayvan);

                if (b)
                {
                    row.Cells[0].Value = frmMusteri.Hayvan.ID;
                    row.Cells[1].Value = frmMusteri.Hayvan.Ad;
                    row.Cells[2].Value = frmMusteri.Hayvan.Tur;
                    row.Cells[3].Value = frmMusteri.Hayvan.Cins;
                    row.Cells[4].Value = frmMusteri.Hayvan.Renk;
                    row.Cells[5].Value = frmMusteri.Hayvan.Dogum;
                    row.Cells[6].Value = frmMusteri.Hayvan.TC;

                }

            }
        }

        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

        }


        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }

        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

        }

        public Hayvan Hayvan { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Hayvan = new Hayvan()
            {
                ID = row.Cells[0].Value.ToString(),
                Ad = row.Cells[1].Value.ToString(),
                Tur = row.Cells[2].Value.ToString(),
                Cins = row.Cells[3].Value.ToString(),
                Renk = row.Cells[4].Value.ToString(),
                Dogum = row.Cells[5].Value.ToString(),
                TC = row.Cells[6].Value.ToString()

            };


            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
