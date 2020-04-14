namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormSeansIptalEt
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
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.lblUzman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIptalNedeni = new System.Windows.Forms.TextBox();
            this.lblSeans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Location = new System.Drawing.Point(398, 259);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
            this.btnIptalEt.TabIndex = 1;
            this.btnIptalEt.Text = "İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // lblUzman
            // 
            this.lblUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUzman.Location = new System.Drawing.Point(259, 27);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(214, 23);
            this.lblUzman.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "İptal Nedeni :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Seans :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Uzman :";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(213, 106);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(260, 2);
            this.lblAyrac.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // txtIptalNedeni
            // 
            this.txtIptalNedeni.Location = new System.Drawing.Point(286, 130);
            this.txtIptalNedeni.Multiline = true;
            this.txtIptalNedeni.Name = "txtIptalNedeni";
            this.txtIptalNedeni.Size = new System.Drawing.Size(187, 112);
            this.txtIptalNedeni.TabIndex = 0;
            // 
            // lblSeans
            // 
            this.lblSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeans.Location = new System.Drawing.Point(259, 61);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(214, 23);
            this.lblSeans.TabIndex = 70;
            // 
            // FormSeansIptalEt
            // 
            this.AcceptButton = this.btnIptalEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.Controls.Add(this.txtIptalNedeni);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.lblSeans);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansIptalEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans İptal Et";
            this.Load += new System.EventHandler(this.FormSeansIptalEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIptalNedeni;
        private System.Windows.Forms.Label lblSeans;
    }
}