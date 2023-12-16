namespace KafeProjesi.WinUI
{
    partial class frmUrunDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunDuzenle));
            groupBox1 = new GroupBox();
            btnUrunuSil = new Button();
            btnGuncelle = new Button();
            cmbKategori = new ComboBox();
            txtUrunFiyati = new TextBox();
            txtUrunAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dtUrunler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtUrunler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnUrunuSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(txtUrunFiyati);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(258, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 421);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürünün";
            // 
            // btnUrunuSil
            // 
            btnUrunuSil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUrunuSil.ForeColor = Color.Black;
            btnUrunuSil.Location = new Point(183, 253);
            btnUrunuSil.Name = "btnUrunuSil";
            btnUrunuSil.Size = new Size(137, 38);
            btnUrunuSil.TabIndex = 6;
            btnUrunuSil.Text = "Sil";
            btnUrunuSil.UseVisualStyleBackColor = true;
            btnUrunuSil.Click += btnUrunuSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(36, 253);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(137, 38);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Düzenle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(100, 185);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(152, 23);
            cmbKategori.TabIndex = 4;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(97, 109);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(155, 23);
            txtUrunFiyati.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(97, 42);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(155, 23);
            txtUrunAdi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(10, 188);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Kategori :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 112);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 0;
            label3.Text = "Fiyatı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 45);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // dtUrunler
            // 
            dtUrunler.BackgroundColor = Color.White;
            dtUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUrunler.Location = new Point(12, 12);
            dtUrunler.Name = "dtUrunler";
            dtUrunler.RowTemplate.Height = 25;
            dtUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtUrunler.Size = new Size(240, 421);
            dtUrunler.TabIndex = 4;
            dtUrunler.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmUrunDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 456);
            Controls.Add(dtUrunler);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUrunDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urun Duzenle";
            Load += frmUrunDuzenle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtUrunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUrunuSil;
        private Button btnGuncelle;
        private ComboBox cmbKategori;
        private TextBox txtUrunFiyati;
        private TextBox txtUrunAdi;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dtUrunler;
    }
}