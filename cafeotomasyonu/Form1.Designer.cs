namespace cafeotomasyonu
{
    partial class Form1
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
            this.btnGarson = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGarson
            // 
            this.btnGarson.FlatAppearance.BorderSize = 0;
            this.btnGarson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarson.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGarson.Image = global::cafeotomasyonu.Properties.Resources.Başlık2sız_2;
            this.btnGarson.Location = new System.Drawing.Point(215, 13);
            this.btnGarson.Margin = new System.Windows.Forms.Padding(4);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(299, 158);
            this.btnGarson.TabIndex = 0;
            this.btnGarson.UseVisualStyleBackColor = true;
            this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.FlatAppearance.BorderSize = 0;
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_23;
            this.btnYonetici.Location = new System.Drawing.Point(174, 369);
            this.btnYonetici.Margin = new System.Windows.Forms.Padding(4);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(299, 158);
            this.btnYonetici.TabIndex = 0;
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_25;
            this.btnCikis.Location = new System.Drawing.Point(516, 449);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(179, 78);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnmusteri
            // 
            this.btnmusteri.BackgroundImage = global::cafeotomasyonu.Properties.Resources.musteri;
            this.btnmusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmusteri.Location = new System.Drawing.Point(490, 191);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(316, 171);
            this.btnmusteri.TabIndex = 14;
            this.btnmusteri.UseVisualStyleBackColor = true;
            this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 20);
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources.Adsız_tasarım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 566);
            this.Controls.Add(this.btnmusteri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnGarson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGarson;
        private System.Windows.Forms.Button btnmusteri;
    }
}

