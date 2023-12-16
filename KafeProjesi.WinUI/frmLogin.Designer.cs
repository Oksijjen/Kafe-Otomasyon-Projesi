namespace KafeProjesi.WinUI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            lblUyari = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(233, 242);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(194, 30);
            txtKullaniciAdi.TabIndex = 2;
            txtKullaniciAdi.Text = "Dimebag";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(233, 297);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(194, 30);
            txtSifre.TabIndex = 2;
            txtSifre.Text = "12345";
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.White;
            btnGirisYap.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Image = (Image)resources.GetObject("btnGirisYap.Image");
            btnGirisYap.ImageAlign = ContentAlignment.MiddleLeft;
            btnGirisYap.Location = new Point(233, 349);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(194, 64);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.TextAlign = ContentAlignment.MiddleRight;
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.ForeColor = Color.Red;
            lblUyari.Location = new Point(92, 427);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(0, 15);
            lblUyari.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(265, 426);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 438);
            Controls.Add(label3);
            Controls.Add(lblUyari);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Label lblUyari;
        private Label label3;
    }
}