namespace cafeotomasyonu
{
    partial class GarsonKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarsonKullaniciGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tboxSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(120, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // tboxKullaniciAdi
            // 
            this.tboxKullaniciAdi.Location = new System.Drawing.Point(206, 39);
            this.tboxKullaniciAdi.MinimumSize = new System.Drawing.Size(60, 30);
            this.tboxKullaniciAdi.Name = "tboxKullaniciAdi";
            this.tboxKullaniciAdi.Size = new System.Drawing.Size(100, 30);
            this.tboxKullaniciAdi.TabIndex = 2;
            this.tboxKullaniciAdi.TextChanged += new System.EventHandler(this.tboxKullaniciAdi_TextChanged);
            // 
            // tboxSifre
            // 
            this.tboxSifre.Location = new System.Drawing.Point(205, 82);
            this.tboxSifre.MinimumSize = new System.Drawing.Size(60, 30);
            this.tboxSifre.Name = "tboxSifre";
            this.tboxSifre.Size = new System.Drawing.Size(100, 30);
            this.tboxSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::cafeotomasyonu.Properties.Resources.Başlıksız_41;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Location = new System.Drawing.Point(96, 124);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(116, 69);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::cafeotomasyonu.Properties.Resources.Başlıksız_52;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(194, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 68);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GarsonKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources._11111;
            this.ClientSize = new System.Drawing.Size(427, 232);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tboxSifre);
            this.Controls.Add(this.tboxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GarsonKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GarsonKullaniciGirisi";
            this.Load += new System.EventHandler(this.GarsonKullaniciGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxKullaniciAdi;
        private System.Windows.Forms.TextBox tboxSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button button2;
    }
}