namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormYeniSeans
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUzman = new System.Windows.Forms.Label();
            this.dtpBaslangicSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisSaati = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(19, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(222, 164);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(245, 2);
            this.lblAyrac.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Uzman :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Başlangıç Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Bitiş Saati :";
            // 
            // lblUzman
            // 
            this.lblUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUzman.Location = new System.Drawing.Point(357, 31);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(100, 23);
            this.lblUzman.TabIndex = 57;
            // 
            // dtpBaslangicSaati
            // 
            this.dtpBaslangicSaati.CustomFormat = "HH:mm";
            this.dtpBaslangicSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangicSaati.Location = new System.Drawing.Point(357, 86);
            this.dtpBaslangicSaati.Name = "dtpBaslangicSaati";
            this.dtpBaslangicSaati.ShowUpDown = true;
            this.dtpBaslangicSaati.Size = new System.Drawing.Size(56, 20);
            this.dtpBaslangicSaati.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(357, 60);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 20);
            this.dtpTarih.TabIndex = 0;
            // 
            // dtpBitisSaati
            // 
            this.dtpBitisSaati.CustomFormat = "HH:mm";
            this.dtpBitisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitisSaati.Location = new System.Drawing.Point(357, 112);
            this.dtpBitisSaati.Name = "dtpBitisSaati";
            this.dtpBitisSaati.ShowUpDown = true;
            this.dtpBitisSaati.Size = new System.Drawing.Size(56, 20);
            this.dtpBitisSaati.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(392, 192);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormYeniSeans
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpBitisSaati);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.dtpBaslangicSaati);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormYeniSeans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kayıt";
            this.Load += new System.EventHandler(this.FormYeniSeans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.DateTimePicker dtpBaslangicSaati;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpBitisSaati;
        private System.Windows.Forms.Button btnKaydet;
    }
}