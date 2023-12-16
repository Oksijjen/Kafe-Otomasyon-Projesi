using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
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
    public partial class frmAdminMasa : Form
    {
        public frmAdminMasa()
        {
            InitializeComponent();
        }


        private void frmAdminMasa_Load(object sender, EventArgs e)
        {

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            ImageList imageList1 = new ImageList();
            imageList.Images.Add("doluMasa.png", Image.FromFile("image\\doluMasa.png"));
            imageList.Images.Add("bosMasa.png", Image.FromFile("image\\bosMasa.png"));

            lstMasa.LargeImageList = imageList;

            int MasaSayisi = 20;
            int DoluMasaSayisi = 0;

            for (int i = 0; i < MasaSayisi; i++)
            {
                ListViewItem masaItem = new ListViewItem((i + 1) + ". Masa");
                if (i < DoluMasaSayisi)
                {
                    masaItem.ImageKey = "doluMasa.png";
                }
                else
                {
                    masaItem.ImageKey = "bosMasa.png";
                }
                lstMasa.Items.Add(masaItem);
            }
            lstMasa.ItemActivate += lstMasa_ItemActivate;

            lstMasa.ContextMenuStrip = new ContextMenuStrip();
            lstMasa.ContextMenuStrip.Items.Add("Masayı Kapat", null, MasayıKapatToolStripMenuItem_Click_Click);
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
        }

        private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunDuzenle frmUrunDuzenle = new frmUrunDuzenle();
            frmUrunDuzenle.Show();
        }

        private void ürünMenüsüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıOluştur frmKullanıcıOluştur = new frmKullanıcıOluştur();
            frmKullanıcıOluştur.Show();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciSil frmKullaniciSil = new frmKullaniciSil();
            frmKullaniciSil.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmŞifreDegistir frmŞifreDegistir = new frmŞifreDegistir();
            frmŞifreDegistir.Show();
        }

        private void lstMasa_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lstMasa.SelectedItems[0];

            if (selectedItem.ImageKey == "bosMasa.png")
            {
                selectedItem.ImageKey = "doluMasa.png";
            }
        }
        private void ToggleMasaDurumu(ListViewItem item)
        {
            if (item.ImageKey == "doluMasa.png")
            {
                item.ImageKey = "bosMasa.png";
            }
            else if (item.ImageKey == "bosMasa.png")
            {
                item.ImageKey = "doluMasa.png";
            }
        }

        private void MasayıKapatToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            if (lstMasa.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstMasa.SelectedItems[0];
                ToggleMasaDurumu(selectedItem);
            }
        }

        private void lstMasa_DoubleClick(object sender, EventArgs e)
        {
            if (lstMasa.SelectedItems.Count > 0)
            {
                ListViewItem selectedMasa = lstMasa.SelectedItems[0];

                frmMasaSiparis frmMasaSiparis = new frmMasaSiparis();

                frmMasaSiparis.Show();
            }
        }

        private void lstMasa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstMasa.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
