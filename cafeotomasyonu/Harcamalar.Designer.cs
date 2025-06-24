namespace cafeotomasyonu
{
    partial class Harcamalar
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
            this.button1 = new System.Windows.Forms.Button();
            this.mtboxtarihara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.harcama = new System.Windows.Forms.DataGridView();
            this.labeltoptut = new System.Windows.Forms.Label();
            this.lbltoptutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.harcama)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtboxtarihara
            // 
            this.mtboxtarihara.Location = new System.Drawing.Point(184, 46);
            this.mtboxtarihara.Mask = "00/00/0000";
            this.mtboxtarihara.Name = "mtboxtarihara";
            this.mtboxtarihara.Size = new System.Drawing.Size(100, 20);
            this.mtboxtarihara.TabIndex = 64;
            this.mtboxtarihara.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tarihe Göre Arama Yap:";
            // 
            // harcama
            // 
            this.harcama.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.harcama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.harcama.Location = new System.Drawing.Point(74, 75);
            this.harcama.Name = "harcama";
            this.harcama.Size = new System.Drawing.Size(538, 216);
            this.harcama.TabIndex = 62;
            // 
            // labeltoptut
            // 
            this.labeltoptut.AutoSize = true;
            this.labeltoptut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltoptut.Location = new System.Drawing.Point(313, 323);
            this.labeltoptut.Name = "labeltoptut";
            this.labeltoptut.Size = new System.Drawing.Size(21, 20);
            this.labeltoptut.TabIndex = 57;
            this.labeltoptut.Text = "--";
            // 
            // lbltoptutar
            // 
            this.lbltoptutar.AutoSize = true;
            this.lbltoptutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoptutar.Location = new System.Drawing.Point(67, 323);
            this.lbltoptutar.Name = "lbltoptutar";
            this.lbltoptutar.Size = new System.Drawing.Size(240, 20);
            this.lbltoptutar.TabIndex = 56;
            this.lbltoptutar.Text = "Bugüne Kadar Toplam Harcama:";
            // 
            // Harcamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources._111111;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtboxtarihara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.harcama);
            this.Controls.Add(this.labeltoptut);
            this.Controls.Add(this.lbltoptutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Harcamalar";
            this.Text = "Harcamalar";
            this.Load += new System.EventHandler(this.Harcamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.harcama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtboxtarihara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView harcama;
        private System.Windows.Forms.Label labeltoptut;
        private System.Windows.Forms.Label lbltoptutar;
    }
}