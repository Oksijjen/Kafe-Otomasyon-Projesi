using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
using KafeProjesi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeProjesi.WinUI
{
    public partial class frmMasaSiparis : Form
    {
        public frmMasaSiparis()
        {
            InitializeComponent();
        }


        private void frmMasaSiparis_Load(object sender, EventArgs e)
        {
            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var UrunListesi = ctx.Urun.Select(u => new
                {
                    UrunAdi = u.UrunAdi,
                    UrunFiyati = u.UrunFiyati,
                    KategoriAdi = u.KategoriAdi,
                }).ToList();

                dtUrunler.DataSource = UrunListesi;
            }

            dtAlinan.Columns.Add("UrunAdi", "Ürün Adı");
            dtAlinan.Columns.Add("UrunFiyati", "Ürün Fiyatı");
            dtAlinan.Columns.Add("KategoriAdi", "Kategori Adı");

        }


        private decimal ToplamTutar = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtUrunler.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dtAlinan.Rows.Add(rowData);

                decimal urunFiyati = Convert.ToDecimal(row.Cells["UrunFiyati"].Value);
                ToplamTutar += urunFiyati;
            }

            txtOdenecekTutar.Text = ToplamTutar.ToString("C2");
        }
        private void btnCikart_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dtAlinan.SelectedRows)
            {
                decimal urunFiyati = 0;

                if (row.Cells["UrunFiyati"].Value != null &&
                    decimal.TryParse(row.Cells["UrunFiyati"].Value.ToString(), out urunFiyati))
                {
                    ToplamTutar -= urunFiyati;

                    dtAlinan.Rows.Remove(row);
                }
            }

            txtOdenecekTutar.Text = ToplamTutar.ToString("C2");

            if (dtAlinan.Rows.Count == 0)
            {
                MessageBox.Show("Ürün çıkartma işlemi bitti");
            }
        }

        private void dtAlinan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private decimal VerilenPara = 0;
        private void btnHesapOde_Click(object sender, EventArgs e)
        {
            decimal odenecekTutar;

            if (decimal.TryParse(txtOdenecekTutar.Text.Replace("₺", "").Trim(), out odenecekTutar))
            {
                decimal kalanTutar = odenecekTutar - VerilenPara;

                if (kalanTutar < 0)
                {
                    MessageBox.Show("Para üstü " + (-kalanTutar).ToString("C2"));
                }
                else
                {
                    MessageBox.Show("Para üstü " + kalanTutar.ToString("C2"));
                    VerilenPara = 0;
                    txtVerilenTutar.Text = "";
                    txtOdenecekTutar.Text = "";
                    dtAlinan.Rows.Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ödeme tutarı");
            }

            txtVerilenTutar.Text = "";
            txtOdenecekTutar.Text = "";
            dtAlinan.Rows.Clear();

        }

        private void txtVerilenTutar_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtVerilenTutar.Text, out VerilenPara))
            {
                decimal odenecekTutar = ToplamTutar;
                if (decimal.TryParse(txtOdenecekTutar.Text.Replace("₺", "").Trim(), out odenecekTutar))
                {
                    decimal kalanTutar = odenecekTutar - VerilenPara;

                }
            }
        }
    }
}
