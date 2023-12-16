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
    public partial class frmKategoriDüzenle : Form
    {
        public frmKategoriDüzenle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string YeniKategoriAdi = txtAdi.Text;

            if (txtAdi.Text == "")
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var YeniKategori = new Ustkategori { KategoriAdi = YeniKategoriAdi };
                ctx.Ustkategori.Add(YeniKategori);
                ctx.SaveChanges();

                txtAdi.Text = string.Empty;

                MessageBox.Show("Yeni kategori oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtAdi.Text = string.Empty;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            string SecilenKategori = cmbKategoriler.SelectedItem.ToString();

            string YeniKategoriAdi = txtKategoriAdi.Text;

            if (cmbKategoriler.Text == "" || txtKategoriAdi.Text == "")
            {
                MessageBox.Show("Lütfen bir kategori seçin ve yeni kategori adı girin");
            }
            else
            {

                using (var ctx = new KafeVeriTabanıDbContext())
                {
                    var DuzenlenecekKategori = ctx.Ustkategori.SingleOrDefault(k => k.KategoriAdi == SecilenKategori);

                    if (DuzenlenecekKategori != null)
                    {
                        DuzenlenecekKategori.KategoriAdi = YeniKategoriAdi;

                        ctx.SaveChanges();


                        txtKategoriAdi.Text = string.Empty;

                        MessageBox.Show("Kategori düzenlendi");
                    }
                }
            }

            txtKategoriAdi.Text = string.Empty;
        }

        private void frmKategoriDüzenle_Load(object sender, EventArgs e)
        {
            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var kategoriAdlari = ctx.Ustkategori.Select(k => k.KategoriAdi).ToList();

                cmbKategoriler.DataSource = kategoriAdlari;
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem != null)
            {
                txtKategoriAdi.Text = cmbKategoriler.SelectedItem.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem != null)
            {
                string kategoriAdi = (string)cmbKategoriler.SelectedValue;

                using (var ctx = new KafeVeriTabanıDbContext())
                {
                    var kategori = ctx.Ustkategori.FirstOrDefault(k => k.KategoriAdi == kategoriAdi);
                    if (kategori != null)
                    {
                        ctx.Ustkategori.Remove(kategori);
                        ctx.SaveChanges();

                        cmbKategoriler.DataSource = ctx.Ustkategori.ToList();

                    }
                }
            }

            txtKategoriAdi.Text = string.Empty;
        }
    }
}
