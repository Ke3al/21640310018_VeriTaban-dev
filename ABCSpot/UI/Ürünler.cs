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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {

            FrmUrun frm = new FrmUrun()
            {
                Text = "Sahip Ekle",
                Sahip = new Sahip(),
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Sahip);

                if (b)
                {

                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnÜrünBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnÜrünDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmUrun frm = new FrmUrun()
            {
                Text = "Sahip Güncelle",
                Güncelleme = true,
                Sahip = new Sahip()
                {
                    TC = row.Cells[0].Value.ToString(),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Numara = row.Cells[3].Value.ToString(),
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGüncelle(frm.Sahip);

                if (b)
                {
                    row.Cells[1].Value = frm.Sahip.Ad;
                    row.Cells[2].Value = frm.Sahip.Soyad;
                    row.Cells[3].Value = frm.Sahip.Numara;
                }

            }
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }

        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

        }

        public Sahip Sahip { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];


            Sahip = new Sahip()
            {
                TC = row.Cells[0].Value.ToString(),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Numara = row.Cells[3].Value.ToString(),


            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
