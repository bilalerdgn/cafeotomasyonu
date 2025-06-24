namespace cafeotomasyonu
{
    partial class Gelirgider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gelirgider));
            this.label1 = new System.Windows.Forms.Label();
            this.tboxsayi = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngiderekle = new System.Windows.Forms.Button();
            this.tboxtutar = new System.Windows.Forms.TextBox();
            this.tboxgider = new System.Windows.Forms.TextBox();
            this.mtboxtarih = new System.Windows.Forms.MaskedTextBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.lblgider = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnharcamalarıgor = new System.Windows.Forms.Button();
            this.btngerii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "SIRA:";
            // 
            // tboxsayi
            // 
            this.tboxsayi.Location = new System.Drawing.Point(102, 116);
            this.tboxsayi.Name = "tboxsayi";
            this.tboxsayi.Size = new System.Drawing.Size(143, 20);
            this.tboxsayi.TabIndex = 28;
            this.tboxsayi.TabStop = false;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(27, 255);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 33);
            this.btnsil.TabIndex = 27;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngiderekle
            // 
            this.btngiderekle.Location = new System.Drawing.Point(133, 255);
            this.btngiderekle.Name = "btngiderekle";
            this.btngiderekle.Size = new System.Drawing.Size(100, 33);
            this.btngiderekle.TabIndex = 26;
            this.btngiderekle.Text = "GİDER EKLE";
            this.btngiderekle.UseVisualStyleBackColor = true;
            this.btngiderekle.Click += new System.EventHandler(this.btngiderekle_Click);
            // 
            // tboxtutar
            // 
            this.tboxtutar.Location = new System.Drawing.Point(102, 180);
            this.tboxtutar.Name = "tboxtutar";
            this.tboxtutar.Size = new System.Drawing.Size(143, 20);
            this.tboxtutar.TabIndex = 25;
            // 
            // tboxgider
            // 
            this.tboxgider.Location = new System.Drawing.Point(102, 147);
            this.tboxgider.Name = "tboxgider";
            this.tboxgider.Size = new System.Drawing.Size(143, 20);
            this.tboxgider.TabIndex = 24;
            // 
            // mtboxtarih
            // 
            this.mtboxtarih.Location = new System.Drawing.Point(102, 213);
            this.mtboxtarih.Mask = "00/00/0000";
            this.mtboxtarih.Name = "mtboxtarih";
            this.mtboxtarih.Size = new System.Drawing.Size(143, 20);
            this.mtboxtarih.TabIndex = 23;
            this.mtboxtarih.ValidatingType = typeof(System.DateTime);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.Location = new System.Drawing.Point(23, 213);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(68, 20);
            this.lbltarih.TabIndex = 22;
            this.lbltarih.Text = "TARİH:";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.Location = new System.Drawing.Point(23, 180);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(72, 20);
            this.lbltutar.TabIndex = 21;
            this.lbltutar.Text = "TUTAR:";
            // 
            // lblgider
            // 
            this.lblgider.AutoSize = true;
            this.lblgider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgider.Location = new System.Drawing.Point(23, 148);
            this.lblgider.Name = "lblgider";
            this.lblgider.Size = new System.Drawing.Size(72, 20);
            this.lblgider.TabIndex = 20;
            this.lblgider.Text = "GİDER:";
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(258, 33);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(442, 330);
            this.DataGridView1.TabIndex = 30;
            // 
            // btnharcamalarıgor
            // 
            this.btnharcamalarıgor.Location = new System.Drawing.Point(102, 382);
            this.btnharcamalarıgor.Name = "btnharcamalarıgor";
            this.btnharcamalarıgor.Size = new System.Drawing.Size(100, 33);
            this.btnharcamalarıgor.TabIndex = 32;
            this.btnharcamalarıgor.Text = "Harcamaları Gör";
            this.btnharcamalarıgor.UseVisualStyleBackColor = true;
            this.btnharcamalarıgor.Click += new System.EventHandler(this.btnharcamalarıgor_Click);
            // 
            // btngerii
            // 
            this.btngerii.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngerii.BackgroundImage")));
            this.btngerii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngerii.FlatAppearance.BorderSize = 0;
            this.btngerii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngerii.Image = global::cafeotomasyonu.Properties.Resources._222333;
            this.btngerii.Location = new System.Drawing.Point(27, 33);
            this.btngerii.Name = "btngerii";
            this.btngerii.Size = new System.Drawing.Size(53, 34);
            this.btngerii.TabIndex = 31;
            this.btngerii.UseVisualStyleBackColor = true;
            this.btngerii.Click += new System.EventHandler(this.btngerii_Click);
            // 
            // Gelirgider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources._11111;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.btnharcamalarıgor);
            this.Controls.Add(this.btngerii);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxsayi);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngiderekle);
            this.Controls.Add(this.tboxtutar);
            this.Controls.Add(this.tboxgider);
            this.Controls.Add(this.mtboxtarih);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.lblgider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gelirgider";
            this.Text = "Gelirgider";
            this.Load += new System.EventHandler(this.Gelirgider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxsayi;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngiderekle;
        private System.Windows.Forms.TextBox tboxtutar;
        private System.Windows.Forms.TextBox tboxgider;
        private System.Windows.Forms.MaskedTextBox mtboxtarih;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label lblgider;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btngerii;
        private System.Windows.Forms.Button btnharcamalarıgor;
    }
}