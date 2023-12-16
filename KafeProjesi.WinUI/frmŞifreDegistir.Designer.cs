namespace KafeProjesi.WinUI
{
    partial class frmŞifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmŞifreDegistir));
            btnOnayla = new Button();
            txtYeniSifreTekrar = new TextBox();
            txtYeniSifre = new TextBox();
            txtEskiSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            SuspendLayout();
            // 
            // btnOnayla
            // 
            btnOnayla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.Image = (Image)resources.GetObject("btnOnayla.Image");
            btnOnayla.ImageAlign = ContentAlignment.MiddleLeft;
            btnOnayla.Location = new Point(195, 217);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(166, 31);
            btnOnayla.TabIndex = 14;
            btnOnayla.Text = "ONAYLA";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(195, 159);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(166, 23);
            txtYeniSifreTekrar.TabIndex = 13;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(195, 112);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(166, 23);
            txtYeniSifre.TabIndex = 12;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(195, 70);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(166, 23);
            txtEskiSifre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 162);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 10;
            label3.Text = "Yeni Şifre (Tekrar) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 115);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 9;
            label2.Text = "Yeni Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 73);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 8;
            label1.Text = "Eski Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 29);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 8;
            label4.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(195, 29);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(166, 23);
            txtKullaniciAdi.TabIndex = 11;
            // 
            // frmŞifreDegistir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 341);
            Controls.Add(btnOnayla);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtEskiSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmŞifreDegistir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Değiştir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOnayla;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private TextBox txtEskiSifre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtKullaniciAdi;
    }
}