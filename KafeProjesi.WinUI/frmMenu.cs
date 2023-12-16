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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            using (var context = new KafeVeriTabanıDbContext())
            {
                var UrunListesi = context.Urun.Select(u => new
                {
                    Ad = u.UrunAdi,
                    Fiyat = u.UrunFiyati,
                    Kategori = u.KategoriAdi,
                }).ToList();

                dataGridView1.DataSource = UrunListesi;
            }
        }
    }
}
