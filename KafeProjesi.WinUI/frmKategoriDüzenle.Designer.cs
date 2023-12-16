namespace KafeProjesi.WinUI
{
    partial class frmKategoriDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriDüzenle));
            groupBox1 = new GroupBox();
            txtAdi = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            groupBox2 = new GroupBox();
            btnSil = new Button();
            label3 = new Label();
            cmbKategoriler = new ComboBox();
            txtKategoriAdi = new TextBox();
            label2 = new Label();
            btnDuzenle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori Ekle";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(110, 47);
            txtAdi.Multiline = true;
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(157, 21);
            txtAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 1;
            label1.Text = "Adı :";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(110, 149);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(126, 34);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbKategoriler);
            groupBox2.Controls.Add(txtKategoriAdi);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnDuzenle);
            groupBox2.Location = new Point(362, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kategori Düzenle";
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(19, 149);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 42);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 4;
            label3.Text = "Adı :";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(149, 45);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(138, 23);
            cmbKategoriler.TabIndex = 3;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(149, 101);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(138, 23);
            txtKategoriAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "Kategoriler : ";
            // 
            // btnDuzenle
            // 
            btnDuzenle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.Image = (Image)resources.GetObject("btnDuzenle.Image");
            btnDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuzenle.Location = new Point(149, 149);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(138, 42);
            btnDuzenle.TabIndex = 0;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // frmKategoriDüzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 256);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKategoriDüzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Düzenle";
            Load += frmKategoriDüzenle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAdi;
        private Label label1;
        private Button btnEkle;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cmbKategoriler;
        private TextBox txtKategoriAdi;
        private Label label2;
        private Button btnDuzenle;
        private Button btnSil;
    }
}