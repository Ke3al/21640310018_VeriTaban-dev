using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ABCSpot.BL;
using ABCSpot.UI;
using static System.Resources.ResXFileRef;

namespace ABCSpot
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatisDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];


            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];


        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Randevu oluştur",
                Randevular = new Randevular()
                {

                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisEkle(frm.Randevular);

                if (b)
                {

                    DataSet ds1 = BLogic.SatisDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                    goto tekrar;

            }


        }



        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmSatis frm = new FrmSatis()
            {
                Text = "Randevu Güncelle",
                Güncelleme = true,
                Randevular = new Randevular()
                {
                    randevuid = row.Cells[0].Value.ToString(),
                    hayvanid = row.Cells[1].Value.ToString(),
                    vetid = row.Cells[2].Value.ToString(),
                    tarihsaatid =  row.Cells[3].Value.ToString()

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGüncelle(frm.Randevular);

                if (b)
                {
                    row.Cells[0].Value = frm.Randevular.randevuid;
                    row.Cells[1].Value = frm.Randevular.hayvanid;
                    row.Cells[2].Value = frm.Randevular.vetid;
                    row.Cells[3].Value = frm.Randevular.tarihsaatid;

                }

            }

        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.SatisDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }


        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Sağlık Geçmişi Oluştur",
                SaglikGecmisi = new SaglikGecmisi()
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.SaglikGecmisi);

                if (b)
                {

                    DataSet ds2 = BLogic.OdemeDetay();
                    if (ds2 != null)
                        dataGridView2.DataSource = ds2.Tables[0];
                }
                else
                    goto tekrar;

            }


        }

        private void btnÖdemeDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Sağlık Geçmişi Güncelle",
                Güncelleme = true,
                SaglikGecmisi = new SaglikGecmisi()
                {
                    gecmisid = row.Cells[0].Value.ToString(),
                    hayvanid = row.Cells[1].Value.ToString(),
                    vetid = row.Cells[2].Value.ToString(),
                    tarihsaatid = row.Cells[3].Value.ToString(),
                    tani =row.Cells[4].Value.ToString(),
                    tedavi = row.Cells[5].Value.ToString(),
        },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGüncelle(frm.SaglikGecmisi);

                if (b)
                {
                    row.Cells[0].Value = frm.SaglikGecmisi.gecmisid;
                    row.Cells[1].Value = frm.SaglikGecmisi.hayvanid;
                    row.Cells[2].Value = frm.SaglikGecmisi.vetid;
                    row.Cells[3].Value = frm.SaglikGecmisi.tarihsaatid;
                    row.Cells[4].Value = frm.SaglikGecmisi.tani;
                    row.Cells[5].Value = frm.SaglikGecmisi.tedavi;

                }

            }

        }

        private void btnÖdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }
    }
}
