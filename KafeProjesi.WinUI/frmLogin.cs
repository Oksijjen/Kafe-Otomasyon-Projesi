using KafeProjesi.Bussiness.Abstract;
using KafeProjesi.Bussiness.Concrate;
using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
using KafeProjesi.Model.Entity;

namespace KafeProjesi.WinUI
{
    public partial class frmLogin : Form
    {
        IKullaniciBs KullaniciBs;
        public frmLogin(IKullaniciBs _KullaniciBs)
        {
            KullaniciBs = _KullaniciBs;
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullaniciAdi.Text;
            string Sifre = txtSifre.Text;

            using (var ctx = new KafeVeriTabanýDbContext())
            {
                var kullanici = ctx.Kullanici.FirstOrDefault(x => x.KullaniciAdi == KullaniciAdi && x.Sifre == Sifre);

                if (kullanici != null)
                {
                    if (kullanici.KullaniciId == 1)
                    {
                        frmAdminMasa admin = new frmAdminMasa();
                        admin.Show();
                    }
                    else if (kullanici.KullaniciId == 2)
                    {
                        frmStuffMasa stuff = new frmStuffMasa();
                        stuff.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlýþ kullanýcý adý veya þifre");
                }
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}