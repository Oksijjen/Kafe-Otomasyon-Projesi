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

namespace KafeProjesi.WinUI
{
    public partial class frmŞifreDegistir : Form
    {
        public frmŞifreDegistir()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullaniciAdi.Text;
            string EskiSifre = txtEskiSifre.Text;
            string YeniSifre = txtYeniSifre.Text;
            string YeniSifreTekrar = txtYeniSifreTekrar.Text;

            if (txtKullaniciAdi.Text == "" || txtEskiSifre.Text == "" || txtYeniSifre.Text == "" || txtYeniSifreTekrar.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (YeniSifre != YeniSifreTekrar)
            {
                MessageBox.Show("Şifreler aynı değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ctx = new KafeVeriTabanıDbContext())
            {
                var kullanici = ctx.Kullanici.FirstOrDefault(u => u.KullaniciAdi == KullaniciAdi && u.Sifre == EskiSifre);

                if (kullanici != null)
                {
                    kullanici.Sifre = YeniSifre;
                    ctx.SaveChanges();
                    MessageBox.Show("Şifre yenilendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada eski şifre hatal.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
