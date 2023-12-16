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
    public partial class frmUrunDuzenle : Form
    {
        public frmUrunDuzenle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dtUrunler.SelectedRows.Count > 0)
            {
                var secilenSatir = dtUrunler.SelectedRows[0];
                var SecilenUrun = secilenSatir.DataBoundItem as Urun;

                if (SecilenUrun != null)
                {
                    string YeniAdi = txtUrunAdi.Text;

                    if (decimal.TryParse(txtUrunFiyati.Text, out decimal YeniFiyati))
                    {
                        using (var ctx = new KafeVeriTabanıDbContext())
                        {
                            var GüncellenenUrun = ctx.Urun.Find(SecilenUrun.Id);

                            if (GüncellenenUrun != null)
                            {
                                GüncellenenUrun.UrunAdi = YeniAdi;
                                GüncellenenUrun.UrunFiyati = YeniFiyati;
                                ctx.SaveChanges();

                                dtUrunler.Refresh();

                                MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün fiyatı geçerli değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen satır bir ürünü temsil etmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmUrunDuzenle_Load(object sender, EventArgs e)
        {
            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var UrunListesi = ctx.Urun.Select(u => new
                {
                    Ad = u.UrunAdi,
                    Fiyat = u.UrunFiyati,
                    Kategori = u.KategoriAdi,
                }).ToList();

                dtUrunler.DataSource = UrunListesi;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dtUrunler.CurrentRow.Cells[0].Value.ToString();
            txtUrunFiyati.Text = dtUrunler.CurrentRow.Cells[1].Value.ToString();
            cmbKategori.Text = dtUrunler.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUrunuSil_Click(object sender, EventArgs e)
        {
            if (dtUrunler.SelectedRows.Count > 0)
            {
                int secilenUrun = dtUrunler.SelectedRows[0].Index;
                string urunadi = (string)dtUrunler.Rows[secilenUrun].Cells["Ad"].Value;

                using (var ctx = new KafeVeriTabanıDbContext())
                {
                    var urun = ctx.Urun.FirstOrDefault(u => u.UrunAdi == urunadi);
                    if (urun != null)
                    {
                        ctx.Urun.Remove(urun);
                        ctx.SaveChanges();

                        var urunListesi = ctx.Urun.Select(u => new { u.UrunAdi, u.UrunFiyati, u.KategoriAdi }).ToList();
                        dtUrunler.DataSource = urunListesi;
                    }
                }
            }

        }
    }
}
