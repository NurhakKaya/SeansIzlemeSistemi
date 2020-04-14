namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormUzmanSeansYonetimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSeanslar = new System.Windows.Forms.ComboBox();
            this.grpHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGsmNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpHastaGecmisi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSeanslar = new System.Windows.Forms.ListBox();
            this.txtGecmisSeansNotu = new System.Windows.Forms.TextBox();
            this.brnGuncelle = new System.Windows.Forms.Button();
            this.grpSeansNotu = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAktifSeansNotu = new System.Windows.Forms.TextBox();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpHastaGecmisi.SuspendLayout();
            this.grpSeansNotu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seanslar";
            // 
            // cbbSeanslar
            // 
            this.cbbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeanslar.FormattingEnabled = true;
            this.cbbSeanslar.Location = new System.Drawing.Point(89, 14);
            this.cbbSeanslar.Name = "cbbSeanslar";
            this.cbbSeanslar.Size = new System.Drawing.Size(267, 21);
            this.cbbSeanslar.TabIndex = 0;
            this.cbbSeanslar.SelectedIndexChanged += new System.EventHandler(this.cbbSeanslar_SelectedIndexChanged);
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.lblAdres);
            this.grpHastaBilgileri.Controls.Add(this.lblGsmNo);
            this.grpHastaBilgileri.Controls.Add(this.lblTelefon);
            this.grpHastaBilgileri.Controls.Add(this.lblEPosta);
            this.grpHastaBilgileri.Controls.Add(this.lblCinsiyet);
            this.grpHastaBilgileri.Controls.Add(this.lblDogumTarihi);
            this.grpHastaBilgileri.Controls.Add(this.lblSoyad);
            this.grpHastaBilgileri.Controls.Add(this.lblAd);
            this.grpHastaBilgileri.Controls.Add(this.lblTCKimlikNo);
            this.grpHastaBilgileri.Controls.Add(this.label22);
            this.grpHastaBilgileri.Controls.Add(this.label20);
            this.grpHastaBilgileri.Controls.Add(this.label18);
            this.grpHastaBilgileri.Controls.Add(this.label16);
            this.grpHastaBilgileri.Controls.Add(this.label14);
            this.grpHastaBilgileri.Controls.Add(this.label12);
            this.grpHastaBilgileri.Controls.Add(this.label10);
            this.grpHastaBilgileri.Controls.Add(this.label8);
            this.grpHastaBilgileri.Controls.Add(this.label7);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(12, 41);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(344, 405);
            this.grpHastaBilgileri.TabIndex = 4;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdres.Location = new System.Drawing.Point(89, 264);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(231, 96);
            this.lblAdres.TabIndex = 13;
            // 
            // lblGsmNo
            // 
            this.lblGsmNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGsmNo.Location = new System.Drawing.Point(89, 233);
            this.lblGsmNo.Name = "lblGsmNo";
            this.lblGsmNo.Size = new System.Drawing.Size(137, 23);
            this.lblGsmNo.TabIndex = 16;
            // 
            // lblTelefon
            // 
            this.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelefon.Location = new System.Drawing.Point(89, 202);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(137, 23);
            this.lblTelefon.TabIndex = 17;
            // 
            // lblEPosta
            // 
            this.lblEPosta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEPosta.Location = new System.Drawing.Point(89, 172);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(137, 23);
            this.lblEPosta.TabIndex = 14;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCinsiyet.Location = new System.Drawing.Point(89, 142);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(137, 23);
            this.lblCinsiyet.TabIndex = 15;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDogumTarihi.Location = new System.Drawing.Point(89, 109);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(137, 23);
            this.lblDogumTarihi.TabIndex = 20;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoyad.Location = new System.Drawing.Point(89, 79);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(137, 23);
            this.lblSoyad.TabIndex = 21;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Location = new System.Drawing.Point(89, 49);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(137, 23);
            this.lblAd.TabIndex = 14;
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(89, 19);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(137, 23);
            this.lblTCKimlikNo.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 269);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Adres :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "GSM No :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Telefon :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Eposta :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Cinsiyeti :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Doğum Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TC Kimlik No :";
            // 
            // grpHastaGecmisi
            // 
            this.grpHastaGecmisi.Controls.Add(this.label2);
            this.grpHastaGecmisi.Controls.Add(this.lstSeanslar);
            this.grpHastaGecmisi.Controls.Add(this.txtGecmisSeansNotu);
            this.grpHastaGecmisi.Controls.Add(this.brnGuncelle);
            this.grpHastaGecmisi.Location = new System.Drawing.Point(362, 41);
            this.grpHastaGecmisi.Name = "grpHastaGecmisi";
            this.grpHastaGecmisi.Size = new System.Drawing.Size(311, 405);
            this.grpHastaGecmisi.TabIndex = 1;
            this.grpHastaGecmisi.TabStop = false;
            this.grpHastaGecmisi.Text = "Hasta Geçmişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Seanslar";
            // 
            // lstSeanslar
            // 
            this.lstSeanslar.FormattingEnabled = true;
            this.lstSeanslar.Location = new System.Drawing.Point(9, 40);
            this.lstSeanslar.Name = "lstSeanslar";
            this.lstSeanslar.ScrollAlwaysVisible = true;
            this.lstSeanslar.Size = new System.Drawing.Size(296, 134);
            this.lstSeanslar.TabIndex = 23;
            this.lstSeanslar.SelectedIndexChanged += new System.EventHandler(this.lstSeanslar_SelectedIndexChanged);
            // 
            // txtGecmisSeansNotu
            // 
            this.txtGecmisSeansNotu.Location = new System.Drawing.Point(9, 180);
            this.txtGecmisSeansNotu.Multiline = true;
            this.txtGecmisSeansNotu.Name = "txtGecmisSeansNotu";
            this.txtGecmisSeansNotu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGecmisSeansNotu.Size = new System.Drawing.Size(296, 189);
            this.txtGecmisSeansNotu.TabIndex = 24;
            // 
            // brnGuncelle
            // 
            this.brnGuncelle.Location = new System.Drawing.Point(230, 375);
            this.brnGuncelle.Name = "brnGuncelle";
            this.brnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.brnGuncelle.TabIndex = 0;
            this.brnGuncelle.Text = "Güncelle";
            this.brnGuncelle.UseVisualStyleBackColor = true;
            this.brnGuncelle.Click += new System.EventHandler(this.brnGuncelle_Click);
            // 
            // grpSeansNotu
            // 
            this.grpSeansNotu.Controls.Add(this.btnKaydet);
            this.grpSeansNotu.Controls.Add(this.txtAktifSeansNotu);
            this.grpSeansNotu.Location = new System.Drawing.Point(679, 41);
            this.grpSeansNotu.Name = "grpSeansNotu";
            this.grpSeansNotu.Size = new System.Drawing.Size(299, 405);
            this.grpSeansNotu.TabIndex = 2;
            this.grpSeansNotu.TabStop = false;
            this.grpSeansNotu.Text = "Seans Notu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(218, 375);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAktifSeansNotu
            // 
            this.txtAktifSeansNotu.Location = new System.Drawing.Point(6, 17);
            this.txtAktifSeansNotu.Multiline = true;
            this.txtAktifSeansNotu.Name = "txtAktifSeansNotu";
            this.txtAktifSeansNotu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAktifSeansNotu.Size = new System.Drawing.Size(287, 352);
            this.txtAktifSeansNotu.TabIndex = 0;
            // 
            // FormUzmanSeansYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 458);
            this.Controls.Add(this.grpHastaGecmisi);
            this.Controls.Add(this.grpSeansNotu);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.cbbSeanslar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUzmanSeansYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzman Seans Yönetimi";
            this.Load += new System.EventHandler(this.FormUzmanSeansYonetimi_Load);
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpHastaGecmisi.ResumeLayout(false);
            this.grpHastaGecmisi.PerformLayout();
            this.grpSeansNotu.ResumeLayout(false);
            this.grpSeansNotu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSeanslar;
        private System.Windows.Forms.GroupBox grpHastaBilgileri;
        private System.Windows.Forms.GroupBox grpHastaGecmisi;
        private System.Windows.Forms.GroupBox grpSeansNotu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblGsmNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSeanslar;
        private System.Windows.Forms.TextBox txtGecmisSeansNotu;
        private System.Windows.Forms.Button brnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAktifSeansNotu;
    }
}