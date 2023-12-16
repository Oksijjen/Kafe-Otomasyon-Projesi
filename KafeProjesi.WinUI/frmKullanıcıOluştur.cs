using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
using KafeProjesi.Model.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KafeProjesi.WinUI
{
    public partial class frmKullanıcıOluştur : Form
    {
        public frmKullanıcıOluştur()
        {
            InitializeComponent();
        }

        private void btnKullaniciyiEkle_Click(object sender, EventArgs e)
        {
            int secilenId;

            if (!int.TryParse(cmbKullaniciId.SelectedItem?.ToString(), out secilenId))
            {
                MessageBox.Show("Lütfen kullanıcı Id seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string adi = txtAdi.Text.Trim();
            string soyadi = txtSoyadi.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (secilenId != 1 && secilenId != 2)
            {
                MessageBox.Show("Sadece 1 veya 2 numaralı ID seçebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kullanici = new Kullanici
            {
                Adi = adi,
                Soyadi = soyadi,
                KullaniciAdi = kullaniciAdi,
                Sifre = sifre,
                KullaniciId = secilenId
            };

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                ctx.Kullanici.Add(kullanici);
                ctx.SaveChanges();
            }

            MessageBox.Show("Kullanıcı oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAdi.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
        }

        private void frmKullanıcıOluştur_Load(object sender, EventArgs e)
        {
            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var KullaniciIds = ctx.Kullanici.Select(u => u.KullaniciId).ToList();
                cmbKullaniciId.DataSource = KullaniciIds;
            }
        }
    }
}
