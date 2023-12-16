namespace KafeProjesi.WinUI
{
    partial class frmStuffMasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStuffMasa));
            lstMasa = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            masayıKapatToolStripMenuItem = new ToolStripMenuItem();
            ımageList1 = new ImageList(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstMasa
            // 
            lstMasa.Location = new Point(12, 12);
            lstMasa.Name = "lstMasa";
            lstMasa.Size = new Size(1288, 698);
            lstMasa.TabIndex = 2;
            lstMasa.UseCompatibleStateImageBehavior = false;
            lstMasa.ItemActivate += lstMasa_ItemActivate;
            lstMasa.SelectedIndexChanged += listView1_SelectedIndexChanged;
            lstMasa.DoubleClick += lstMasa_DoubleClick;
            lstMasa.MouseClick += lstMasa_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { masayıKapatToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 26);
            // 
            // masayıKapatToolStripMenuItem
            // 
            masayıKapatToolStripMenuItem.Name = "masayıKapatToolStripMenuItem";
            masayıKapatToolStripMenuItem.Size = new Size(144, 22);
            masayıKapatToolStripMenuItem.Text = "Masayı Kapat";
            masayıKapatToolStripMenuItem.Click += masayıKapatToolStripMenuItem_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // frmStuffMasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 717);
            Controls.Add(lstMasa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStuffMasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Masa";
            Load += frmStuffMasa_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lstMasa;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem masayıKapatToolStripMenuItem;
        private ImageList ımageList1;
    }
}