using KafeProjesi.Bussiness.Concrate;
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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var Kategoriıds = ctx.Ustkategori.ToList();
                cmbUstKategori.DataSource = Kategoriıds;
                cmbUstKategori.DisplayMember = "KategoriAdi";
            }

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var Boyutlar = ctx.Boyutlar.ToList();
                cmbBoyut.DataSource = Boyutlar;
                cmbBoyut.DisplayMember = "BoyutAdi";
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            frmKategoriDüzenle frmKategoriDüzenle = new frmKategoriDüzenle();
            frmKategoriDüzenle.ShowDialog();
        }

        private void cmbUstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnUrunuEkle_Click(object sender, EventArgs e)
        {
            if (cmbUstKategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUrunAdi.Text == "" || txtUrunFiyati.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string urunAdi = txtUrunAdi.Text;
            decimal urunFiyati;

            if (!decimal.TryParse(txtUrunFiyati.Text, out urunFiyati))
            {
                MessageBox.Show("Ürün fiyatı geçerli değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string BoyutAdi = string.Empty;

            if (cmbBoyut.SelectedItem != null)
            {
                var boyut = (Boyutlar)cmbBoyut.SelectedItem;
                BoyutAdi = boyut.BoyutAdi;
            }

            if (cmbUstKategori.SelectedItem != null)
            {
                var UstKategori = (Ustkategori)cmbUstKategori.SelectedItem;
                string KatAdii = UstKategori.KategoriAdi;

            }

            string katAdi = cmbUstKategori.Text;

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                Urun yeniUrun = new Urun
                {
                    UrunAdi = urunAdi,
                    UrunFiyati = urunFiyati,
                    KategoriAdi = katAdi,
                    BoyutAdi = BoyutAdi
                };

                ctx.Urun.Add(yeniUrun);
                ctx.SaveChanges();
            }
            MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtUrunAdi.Text = string.Empty;
            txtUrunFiyati.Text = string.Empty;

        }
    }
}
