namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormParolaSifirla
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
            this.btnSifirla = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(359, 138);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(334, 48);
            this.txtParola.MaxLength = 10;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 1;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(334, 24);
            this.txtEPosta.MaxLength = 100;
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(100, 20);
            this.txtEPosta.TabIndex = 0;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(199, 114);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(235, 2);
            this.lblAyrac.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Yeni Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(199, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "EPosta :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.BosResim;
            this.pictureBox1.Location = new System.Drawing.Point(11, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormParolaSifirla
            // 
            this.AcceptButton = this.btnSifirla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 282);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormParolaSifirla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Sıfırlama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}