namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormParolaDegistir
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtYeni2 = new System.Windows.Forms.TextBox();
            this.txtYeni1 = new System.Windows.Forms.TextBox();
            this.txtEski = new System.Windows.Forms.TextBox();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(354, 167);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 3;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtYeni2
            // 
            this.txtYeni2.Location = new System.Drawing.Point(329, 77);
            this.txtYeni2.MaxLength = 10;
            this.txtYeni2.Name = "txtYeni2";
            this.txtYeni2.PasswordChar = '*';
            this.txtYeni2.Size = new System.Drawing.Size(100, 20);
            this.txtYeni2.TabIndex = 2;
            // 
            // txtYeni1
            // 
            this.txtYeni1.Location = new System.Drawing.Point(329, 53);
            this.txtYeni1.MaxLength = 10;
            this.txtYeni1.Name = "txtYeni1";
            this.txtYeni1.PasswordChar = '*';
            this.txtYeni1.Size = new System.Drawing.Size(100, 20);
            this.txtYeni1.TabIndex = 1;
            // 
            // txtEski
            // 
            this.txtEski.Location = new System.Drawing.Point(329, 29);
            this.txtEski.MaxLength = 10;
            this.txtEski.Name = "txtEski";
            this.txtEski.PasswordChar = '*';
            this.txtEski.Size = new System.Drawing.Size(100, 20);
            this.txtEski.TabIndex = 0;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(194, 143);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(235, 2);
            this.lblAyrac.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(194, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yeni Parola (Tekrar) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(194, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yeni Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eski Parola :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormParolaDegistir
            // 
            this.AcceptButton = this.btnDegistir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 292);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtYeni2);
            this.Controls.Add(this.txtYeni1);
            this.Controls.Add(this.txtEski);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormParolaDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştirme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtYeni2;
        private System.Windows.Forms.TextBox txtYeni1;
        private System.Windows.Forms.TextBox txtEski;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}