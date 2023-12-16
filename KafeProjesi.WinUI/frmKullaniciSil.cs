using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
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
    public partial class frmKullaniciSil : Form
    {
        public frmKullaniciSil()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string ad = txtAdi.Text;
            string soyad = txtSoyadi.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var kullanici = ctx.Kullanici.FirstOrDefault(u =>
                    u.Adi == ad &&
                    u.Soyadi == soyad &&
                    u.KullaniciAdi == kullaniciAdi &&
                    u.Sifre == sifre);

                if (kullanici != null)
                {
                    ctx.Kullanici.Remove(kullanici);
                    ctx.SaveChanges();
                    MessageBox.Show("Kullanıcı silindi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı veya biilgiler yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            txtAdi.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
        }
    }

}
