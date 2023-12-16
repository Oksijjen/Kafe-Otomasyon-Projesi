namespace KafeProjesi.WinUI
{
    partial class frmKullaniciSil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnOnayla = new Button();
            lblUyari = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 115);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 0;
            label4.Text = "Şifre :";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(172, 26);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(166, 23);
            txtAdi.TabIndex = 1;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(172, 70);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(166, 23);
            txtSoyadi.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(172, 117);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(166, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(172, 159);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(166, 23);
            txtSifre.TabIndex = 1;
            // 
            // btnOnayla
            // 
            btnOnayla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.Location = new Point(172, 207);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(166, 30);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUyari.ForeColor = Color.Red;
            lblUyari.Location = new Point(30, 217);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(0, 20);
            lblUyari.TabIndex = 3;
            // 
            // frmKullaniciSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 290);
            Controls.Add(lblUyari);
            Controls.Add(btnOnayla);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ImeMode = ImeMode.NoControl;
            Name = "frmKullaniciSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Sil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnOnayla;
        private Label lblUyari;
    }
}