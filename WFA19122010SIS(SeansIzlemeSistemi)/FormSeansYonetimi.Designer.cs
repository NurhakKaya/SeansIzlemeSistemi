namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormSeansYonetimi
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
            this.lstSeanslar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbUzmanlar = new System.Windows.Forms.ComboBox();
            this.lnkSeansEkle = new System.Windows.Forms.LinkLabel();
            this.lnkSeansIptalEt = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSeanslar
            // 
            this.lstSeanslar.FormattingEnabled = true;
            this.lstSeanslar.Location = new System.Drawing.Point(256, 91);
            this.lstSeanslar.Name = "lstSeanslar";
            this.lstSeanslar.ScrollAlwaysVisible = true;
            this.lstSeanslar.Size = new System.Drawing.Size(245, 251);
            this.lstSeanslar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Seanslar";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(256, 57);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(245, 2);
            this.lblAyrac.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Uzman :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // cbbUzmanlar
            // 
            this.cbbUzmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUzmanlar.FormattingEnabled = true;
            this.cbbUzmanlar.Location = new System.Drawing.Point(327, 23);
            this.cbbUzmanlar.Name = "cbbUzmanlar";
            this.cbbUzmanlar.Size = new System.Drawing.Size(121, 21);
            this.cbbUzmanlar.TabIndex = 0;
            this.cbbUzmanlar.SelectedIndexChanged += new System.EventHandler(this.cbbUzmanlar_SelectedIndexChanged);
            // 
            // lnkSeansEkle
            // 
            this.lnkSeansEkle.AutoSize = true;
            this.lnkSeansEkle.Location = new System.Drawing.Point(416, 68);
            this.lnkSeansEkle.Name = "lnkSeansEkle";
            this.lnkSeansEkle.Size = new System.Drawing.Size(85, 13);
            this.lnkSeansEkle.TabIndex = 1;
            this.lnkSeansEkle.TabStop = true;
            this.lnkSeansEkle.Text = "Yeni Seans Ekle";
            this.lnkSeansEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSeansEkle_LinkClicked);
            // 
            // lnkSeansIptalEt
            // 
            this.lnkSeansIptalEt.AutoSize = true;
            this.lnkSeansIptalEt.Location = new System.Drawing.Point(398, 350);
            this.lnkSeansIptalEt.Name = "lnkSeansIptalEt";
            this.lnkSeansIptalEt.Size = new System.Drawing.Size(103, 13);
            this.lnkSeansIptalEt.TabIndex = 3;
            this.lnkSeansIptalEt.TabStop = true;
            this.lnkSeansIptalEt.Text = "Seçili Seansı İptal Et";
            this.lnkSeansIptalEt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSeansIptalEt_LinkClicked);
            // 
            // FormSeansYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 372);
            this.Controls.Add(this.lnkSeansIptalEt);
            this.Controls.Add(this.lnkSeansEkle);
            this.Controls.Add(this.cbbUzmanlar);
            this.Controls.Add(this.lstSeanslar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Yönetimi";
            this.Load += new System.EventHandler(this.FormSeansYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSeanslar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbUzmanlar;
        private System.Windows.Forms.LinkLabel lnkSeansEkle;
        private System.Windows.Forms.LinkLabel lnkSeansIptalEt;

    }
}