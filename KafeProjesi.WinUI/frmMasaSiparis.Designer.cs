namespace KafeProjesi.WinUI
{
    partial class frmMasaSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaSiparis));
            dtAlinan = new DataGridView();
            dtUrunler = new DataGridView();
            btnCikart = new Button();
            btnEkle = new Button();
            groupBox1 = new GroupBox();
            btnHesapOde = new Button();
            txtVerilenTutar = new TextBox();
            txtOdenecekTutar = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtAlinan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtUrunler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtAlinan
            // 
            dtAlinan.BackgroundColor = Color.White;
            dtAlinan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtAlinan.Location = new Point(483, 75);
            dtAlinan.Name = "dtAlinan";
            dtAlinan.RowTemplate.Height = 25;
            dtAlinan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtAlinan.Size = new Size(325, 585);
            dtAlinan.TabIndex = 15;
            dtAlinan.CellContentClick += dtAlinan_CellContentClick;
            // 
            // dtUrunler
            // 
            dtUrunler.BackgroundColor = Color.White;
            dtUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUrunler.Location = new Point(22, 75);
            dtUrunler.Name = "dtUrunler";
            dtUrunler.RowTemplate.Height = 25;
            dtUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtUrunler.Size = new Size(322, 585);
            dtUrunler.TabIndex = 16;
            // 
            // btnCikart
            // 
            btnCikart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikart.Image = (Image)resources.GetObject("btnCikart.Image");
            btnCikart.Location = new Point(350, 335);
            btnCikart.Name = "btnCikart";
            btnCikart.Size = new Size(127, 56);
            btnCikart.TabIndex = 13;
            btnCikart.UseVisualStyleBackColor = true;
            btnCikart.Click += btnCikart_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.Location = new Point(350, 273);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(127, 56);
            btnEkle.TabIndex = 14;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnHesapOde);
            groupBox1.Controls.Add(txtVerilenTutar);
            groupBox1.Controls.Add(txtOdenecekTutar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(814, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 585);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Tutarı";
            // 
            // btnHesapOde
            // 
            btnHesapOde.BackColor = Color.Transparent;
            btnHesapOde.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapOde.Image = (Image)resources.GetObject("btnHesapOde.Image");
            btnHesapOde.ImageAlign = ContentAlignment.MiddleLeft;
            btnHesapOde.Location = new Point(80, 169);
            btnHesapOde.Name = "btnHesapOde";
            btnHesapOde.Size = new Size(172, 66);
            btnHesapOde.TabIndex = 4;
            btnHesapOde.Text = "Hesap Öde";
            btnHesapOde.UseVisualStyleBackColor = false;
            btnHesapOde.Click += btnHesapOde_Click;
            // 
            // txtVerilenTutar
            // 
            txtVerilenTutar.Location = new Point(198, 99);
            txtVerilenTutar.Name = "txtVerilenTutar";
            txtVerilenTutar.Size = new Size(141, 23);
            txtVerilenTutar.TabIndex = 3;
            txtVerilenTutar.TextChanged += txtVerilenTutar_TextChanged;
            // 
            // txtOdenecekTutar
            // 
            txtOdenecekTutar.Location = new Point(198, 47);
            txtOdenecekTutar.Name = "txtOdenecekTutar";
            txtOdenecekTutar.Size = new Size(141, 23);
            txtOdenecekTutar.TabIndex = 3;
            txtOdenecekTutar.Text = "0,0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(138, 30);
            label4.TabIndex = 1;
            label4.Text = "Verilen Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(167, 30);
            label3.TabIndex = 0;
            label3.Text = "Ödenecek Tutar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(931, 17);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 10;
            label6.Text = "HESAP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(578, 17);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 11;
            label2.Text = "ALINAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(87, 17);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 9;
            label1.Text = "ÜRÜNLER";
            // 
            // frmMasaSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 692);
            Controls.Add(dtAlinan);
            Controls.Add(dtUrunler);
            Controls.Add(btnCikart);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMasaSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş";
            Load += frmMasaSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)dtAlinan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtUrunler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtAlinan;
        private DataGridView dtUrunler;
        private Button btnCikart;
        private Button btnEkle;
        private GroupBox groupBox1;
        private Button btnHesapOde;
        private TextBox txtVerilenTutar;
        private TextBox txtOdenecekTutar;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label1;
    }
}