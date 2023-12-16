namespace KafeProjesi.WinUI
{
    partial class frmKullanıcıOluştur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanıcıOluştur));
            btnKullaniciyiEkle = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUyari = new Label();
            label5 = new Label();
            cmbKullaniciId = new ComboBox();
            SuspendLayout();
            // 
            // btnKullaniciyiEkle
            // 
            btnKullaniciyiEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullaniciyiEkle.Image = (Image)resources.GetObject("btnKullaniciyiEkle.Image");
            btnKullaniciyiEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullaniciyiEkle.Location = new Point(176, 250);
            btnKullaniciyiEkle.Name = "btnKullaniciyiEkle";
            btnKullaniciyiEkle.Size = new Size(191, 42);
            btnKullaniciyiEkle.TabIndex = 11;
            btnKullaniciyiEkle.Text = "Kullanıcıyı Ekle";
            btnKullaniciyiEkle.UseVisualStyleBackColor = true;
            btnKullaniciyiEkle.Click += btnKullaniciyiEkle_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(176, 174);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(191, 23);
            txtSifre.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(176, 132);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(191, 23);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(176, 85);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(191, 23);
            txtSoyadi.TabIndex = 9;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(176, 41);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(191, 23);
            txtAdi.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 172);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 5;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 6;
            label1.Text = "Adı :";
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUyari.ForeColor = Color.Red;
            lblUyari.Location = new Point(34, 231);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(0, 21);
            lblUyari.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 210);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 3;
            label5.Text = "Personel ID :";
            // 
            // cmbKullaniciId
            // 
            cmbKullaniciId.FormattingEnabled = true;
            cmbKullaniciId.Location = new Point(176, 217);
            cmbKullaniciId.Name = "cmbKullaniciId";
            cmbKullaniciId.Size = new Size(191, 23);
            cmbKullaniciId.TabIndex = 13;
            // 
            // frmKullanıcıOluştur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 318);
            Controls.Add(cmbKullaniciId);
            Controls.Add(lblUyari);
            Controls.Add(btnKullaniciyiEkle);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKullanıcıOluştur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Oluştur";
            Load += frmKullanıcıOluştur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKullaniciyiEkle;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblUyari;
        private Label label5;
        private ComboBox cmbKullaniciId;
    }
}