
namespace cafeotomasyonu
{
    partial class musterigiris
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tboxSifre = new System.Windows.Forms.TextBox();
            this.tboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_5;
            this.btnCikis.Location = new System.Drawing.Point(395, 228);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(88, 73);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_4;
            this.btnGiris.Location = new System.Drawing.Point(287, 228);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(87, 73);
            this.btnGiris.TabIndex = 15;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tboxSifre
            // 
            this.tboxSifre.Location = new System.Drawing.Point(363, 171);
            this.tboxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.tboxSifre.MinimumSize = new System.Drawing.Size(79, 30);
            this.tboxSifre.Name = "tboxSifre";
            this.tboxSifre.Size = new System.Drawing.Size(159, 30);
            this.tboxSifre.TabIndex = 14;
            // 
            // tboxKullaniciAdi
            // 
            this.tboxKullaniciAdi.Location = new System.Drawing.Point(363, 109);
            this.tboxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tboxKullaniciAdi.MinimumSize = new System.Drawing.Size(79, 30);
            this.tboxKullaniciAdi.Name = "tboxKullaniciAdi";
            this.tboxKullaniciAdi.Size = new System.Drawing.Size(159, 30);
            this.tboxKullaniciAdi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::cafeotomasyonu.Properties.Resources._5;
            this.label2.Location = new System.Drawing.Point(249, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::cafeotomasyonu.Properties.Resources._5;
            this.label1.Location = new System.Drawing.Point(217, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // musterigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources._11111;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tboxSifre);
            this.Controls.Add(this.tboxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "musterigiris";
            this.Text = "musterigiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tboxSifre;
        private System.Windows.Forms.TextBox tboxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}