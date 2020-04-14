namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormRandevuKaydet
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbUzmanlar = new System.Windows.Forms.ComboBox();
            this.cbbSeanslar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(396, 191);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasta.Location = new System.Drawing.Point(257, 26);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(214, 23);
            this.lblHasta.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Uzman :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Hasta :";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(211, 167);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(260, 2);
            this.lblAyrac.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Seans :";
            // 
            // cbbUzmanlar
            // 
            this.cbbUzmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUzmanlar.FormattingEnabled = true;
            this.cbbUzmanlar.Location = new System.Drawing.Point(257, 67);
            this.cbbUzmanlar.Name = "cbbUzmanlar";
            this.cbbUzmanlar.Size = new System.Drawing.Size(214, 21);
            this.cbbUzmanlar.TabIndex = 0;
            this.cbbUzmanlar.SelectedIndexChanged += new System.EventHandler(this.cbbUzmanlar_SelectedIndexChanged);
            // 
            // cbbSeanslar
            // 
            this.cbbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeanslar.FormattingEnabled = true;
            this.cbbSeanslar.Location = new System.Drawing.Point(257, 99);
            this.cbbSeanslar.Name = "cbbSeanslar";
            this.cbbSeanslar.Size = new System.Drawing.Size(214, 21);
            this.cbbSeanslar.TabIndex = 1;
            this.cbbSeanslar.SelectedIndexChanged += new System.EventHandler(this.cbbSeanslar_SelectedIndexChanged);
            // 
            // FormRandevuKaydet
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 277);
            this.Controls.Add(this.cbbSeanslar);
            this.Controls.Add(this.cbbUzmanlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRandevuKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kaydet";
            this.Load += new System.EventHandler(this.FormRandevuKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbUzmanlar;
        private System.Windows.Forms.ComboBox cbbSeanslar;
    }
}