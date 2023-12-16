namespace KafeProjesi.WinUI
{
    partial class frmAdminMasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMasa));
            lstMasa = new ListView();
            menuStrip1 = new MenuStrip();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünDüzenleToolStripMenuItem = new ToolStripMenuItem();
            ürünMenüsüToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıEkleToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıSilToolStripMenuItem = new ToolStripMenuItem();
            şifreDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            MasayıKapatToolStripMenuItem_Click = new ToolStripMenuItem();
            ımageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstMasa
            // 
            lstMasa.Location = new Point(12, 27);
            lstMasa.Name = "lstMasa";
            lstMasa.Size = new Size(1275, 698);
            lstMasa.TabIndex = 0;
            lstMasa.UseCompatibleStateImageBehavior = false;
            lstMasa.ItemActivate += lstMasa_ItemActivate;
            lstMasa.DoubleClick += lstMasa_DoubleClick;
            lstMasa.MouseClick += lstMasa_MouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünlerToolStripMenuItem, kullanıcıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem, ürünDüzenleToolStripMenuItem, ürünMenüsüToolStripMenuItem });
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(58, 20);
            ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(180, 22);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ürünDüzenleToolStripMenuItem
            // 
            ürünDüzenleToolStripMenuItem.Name = "ürünDüzenleToolStripMenuItem";
            ürünDüzenleToolStripMenuItem.Size = new Size(180, 22);
            ürünDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            ürünDüzenleToolStripMenuItem.Click += ürünDüzenleToolStripMenuItem_Click;
            // 
            // ürünMenüsüToolStripMenuItem
            // 
            ürünMenüsüToolStripMenuItem.Name = "ürünMenüsüToolStripMenuItem";
            ürünMenüsüToolStripMenuItem.Size = new Size(180, 22);
            ürünMenüsüToolStripMenuItem.Text = "Ürün Menüsü";
            ürünMenüsüToolStripMenuItem.Click += ürünMenüsüToolStripMenuItem_Click;
            // 
            // kullanıcıToolStripMenuItem
            // 
            kullanıcıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıEkleToolStripMenuItem, kullanıcıSilToolStripMenuItem, şifreDeğiştirToolStripMenuItem });
            kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            kullanıcıToolStripMenuItem.Size = new Size(64, 20);
            kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            kullanıcıEkleToolStripMenuItem.Size = new Size(143, 22);
            kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            kullanıcıEkleToolStripMenuItem.Click += kullanıcıEkleToolStripMenuItem_Click;
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            kullanıcıSilToolStripMenuItem.Size = new Size(143, 22);
            kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            kullanıcıSilToolStripMenuItem.Click += kullanıcıSilToolStripMenuItem_Click;
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            şifreDeğiştirToolStripMenuItem.Size = new Size(143, 22);
            şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            şifreDeğiştirToolStripMenuItem.Click += şifreDeğiştirToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { MasayıKapatToolStripMenuItem_Click });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 26);
            // 
            // MasayıKapatToolStripMenuItem_Click
            // 
            MasayıKapatToolStripMenuItem_Click.Name = "MasayıKapatToolStripMenuItem_Click";
            MasayıKapatToolStripMenuItem_Click.Size = new Size(144, 22);
            MasayıKapatToolStripMenuItem_Click.Text = "Masayı Kapat";
            MasayıKapatToolStripMenuItem_Click.Click += MasayıKapatToolStripMenuItem_Click_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // frmAdminMasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 737);
            Controls.Add(lstMasa);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmAdminMasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Masa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstMasa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünDüzenleToolStripMenuItem;
        private ToolStripMenuItem ürünMenüsüToolStripMenuItem;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MasayıKapatToolStripMenuItem_Click;
        private ImageList ımageList1;
    }
}