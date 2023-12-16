namespace KafeProjesi.WinUI
{
    partial class frmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEkle));
            groupBox1 = new GroupBox();
            txtUrunFiyati = new TextBox();
            txtUrunAdi = new TextBox();
            cmbBoyut = new ComboBox();
            cmbUstKategori = new ComboBox();
            btnKategoriEkle = new Button();
            bnUrunuEkle = new Button();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUrunFiyati);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(cmbBoyut);
            groupBox1.Controls.Add(cmbUstKategori);
            groupBox1.Controls.Add(btnKategoriEkle);
            groupBox1.Controls.Add(bnUrunuEkle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürünün";
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(121, 80);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(165, 23);
            txtUrunFiyati.TabIndex = 8;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(119, 35);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(167, 23);
            txtUrunAdi.TabIndex = 7;
            // 
            // cmbBoyut
            // 
            cmbBoyut.FormattingEnabled = true;
            cmbBoyut.Location = new Point(122, 179);
            cmbBoyut.Name = "cmbBoyut";
            cmbBoyut.Size = new Size(164, 23);
            cmbBoyut.TabIndex = 6;
            cmbBoyut.SelectedIndexChanged += cmbUstKategori_SelectedIndexChanged;
            // 
            // cmbUstKategori
            // 
            cmbUstKategori.FormattingEnabled = true;
            cmbUstKategori.Location = new Point(122, 134);
            cmbUstKategori.Name = "cmbUstKategori";
            cmbUstKategori.Size = new Size(164, 23);
            cmbUstKategori.TabIndex = 6;
            cmbUstKategori.SelectedIndexChanged += cmbUstKategori_SelectedIndexChanged;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKategoriEkle.Location = new Point(347, 33);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(164, 39);
            btnKategoriEkle.TabIndex = 5;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // bnUrunuEkle
            // 
            bnUrunuEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnUrunuEkle.Image = (Image)resources.GetObject("bnUrunuEkle.Image");
            bnUrunuEkle.ImageAlign = ContentAlignment.MiddleLeft;
            bnUrunuEkle.Location = new Point(119, 227);
            bnUrunuEkle.Name = "bnUrunuEkle";
            bnUrunuEkle.Size = new Size(165, 49);
            bnUrunuEkle.TabIndex = 5;
            bnUrunuEkle.Text = "Ürünü Ekle";
            bnUrunuEkle.UseVisualStyleBackColor = true;
            bnUrunuEkle.Click += bnUrunuEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 236);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 180);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 2;
            label6.Text = "Boyutu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Kategorisi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // frmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 340);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urun Ekle";
            Load += frmUrunEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtUrunFiyati;
        private TextBox txtUrunAdi;
        private ComboBox cmbUstKategori;
        private Button btnKategoriEkle;
        private Button bnUrunuEkle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbBoyut;
        private Label label6;
    }
}