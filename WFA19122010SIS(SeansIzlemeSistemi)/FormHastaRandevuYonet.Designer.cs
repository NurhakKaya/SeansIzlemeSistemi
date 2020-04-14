namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormHastaRandevuYonet
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
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkYeniHastaGir = new System.Windows.Forms.LinkLabel();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lnkHastaGuncelle = new System.Windows.Forms.LinkLabel();
            this.grpRandevuBilgileri = new System.Windows.Forms.GroupBox();
            this.lnkRandevuIptalEt = new System.Windows.Forms.LinkLabel();
            this.lnkYeniRandevu = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSeansNot = new System.Windows.Forms.Label();
            this.lblSeansSeans = new System.Windows.Forms.Label();
            this.lblSeansUzman = new System.Windows.Forms.Label();
            this.lblRandevuSeans = new System.Windows.Forms.Label();
            this.lblRandevuUzman = new System.Windows.Forms.Label();
            this.grpArama.SuspendLayout();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpRandevuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.label3);
            this.grpArama.Controls.Add(this.lnkYeniHastaGir);
            this.grpArama.Controls.Add(this.lstHastalar);
            this.grpArama.Controls.Add(this.txtAd);
            this.grpArama.Controls.Add(this.txtSoyad);
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.label2);
            this.grpArama.Controls.Add(this.label1);
            this.grpArama.Location = new System.Drawing.Point(12, 12);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(313, 440);
            this.grpArama.TabIndex = 0;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hastalar";
            // 
            // lnkYeniHastaGir
            // 
            this.lnkYeniHastaGir.AutoSize = true;
            this.lnkYeniHastaGir.Location = new System.Drawing.Point(223, 116);
            this.lnkYeniHastaGir.Name = "lnkYeniHastaGir";
            this.lnkYeniHastaGir.Size = new System.Drawing.Size(84, 13);
            this.lnkYeniHastaGir.TabIndex = 3;
            this.lnkYeniHastaGir.TabStop = true;
            this.lnkYeniHastaGir.Text = "Yeni Hasta Girişi";
            this.lnkYeniHastaGir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniHastaGir_LinkClicked);
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(9, 148);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.ScrollAlwaysVisible = true;
            this.lstHastalar.Size = new System.Drawing.Size(298, 277);
            this.lstHastalar.TabIndex = 4;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 14);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(158, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(100, 40);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(158, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(183, 77);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
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
            this.grpHastaBilgileri.Controls.Add(this.lnkHastaGuncelle);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(331, 12);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(302, 440);
            this.grpHastaBilgileri.TabIndex = 1;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdres.Location = new System.Drawing.Point(100, 291);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(196, 134);
            this.lblAdres.TabIndex = 3;
            // 
            // lblGsmNo
            // 
            this.lblGsmNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGsmNo.Location = new System.Drawing.Point(100, 260);
            this.lblGsmNo.Name = "lblGsmNo";
            this.lblGsmNo.Size = new System.Drawing.Size(137, 23);
            this.lblGsmNo.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelefon.Location = new System.Drawing.Point(100, 229);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(137, 23);
            this.lblTelefon.TabIndex = 3;
            // 
            // lblEPosta
            // 
            this.lblEPosta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEPosta.Location = new System.Drawing.Point(100, 199);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(137, 23);
            this.lblEPosta.TabIndex = 3;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCinsiyet.Location = new System.Drawing.Point(100, 169);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(137, 23);
            this.lblCinsiyet.TabIndex = 3;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDogumTarihi.Location = new System.Drawing.Point(100, 136);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(137, 23);
            this.lblDogumTarihi.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoyad.Location = new System.Drawing.Point(100, 106);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(137, 23);
            this.lblSoyad.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Location = new System.Drawing.Point(100, 76);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(137, 23);
            this.lblAd.TabIndex = 3;
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(100, 46);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(137, 23);
            this.lblTCKimlikNo.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Adres :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "GSM :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Telefon :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Eposta :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cinsiyeti :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Doğum Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "TC Kimlik No :";
            // 
            // lnkHastaGuncelle
            // 
            this.lnkHastaGuncelle.AutoSize = true;
            this.lnkHastaGuncelle.Location = new System.Drawing.Point(173, 21);
            this.lnkHastaGuncelle.Name = "lnkHastaGuncelle";
            this.lnkHastaGuncelle.Size = new System.Drawing.Size(123, 13);
            this.lnkHastaGuncelle.TabIndex = 0;
            this.lnkHastaGuncelle.TabStop = true;
            this.lnkHastaGuncelle.Text = "Hasta Bilgilerini Güncelle";
            this.lnkHastaGuncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHastaGuncelle_LinkClicked);
            // 
            // grpRandevuBilgileri
            // 
            this.grpRandevuBilgileri.Controls.Add(this.lnkRandevuIptalEt);
            this.grpRandevuBilgileri.Controls.Add(this.lnkYeniRandevu);
            this.grpRandevuBilgileri.Controls.Add(this.label25);
            this.grpRandevuBilgileri.Controls.Add(this.label23);
            this.grpRandevuBilgileri.Controls.Add(this.label15);
            this.grpRandevuBilgileri.Controls.Add(this.label21);
            this.grpRandevuBilgileri.Controls.Add(this.label27);
            this.grpRandevuBilgileri.Controls.Add(this.label26);
            this.grpRandevuBilgileri.Controls.Add(this.label9);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansNot);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansUzman);
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuUzman);
            this.grpRandevuBilgileri.Location = new System.Drawing.Point(639, 12);
            this.grpRandevuBilgileri.Name = "grpRandevuBilgileri";
            this.grpRandevuBilgileri.Size = new System.Drawing.Size(340, 440);
            this.grpRandevuBilgileri.TabIndex = 2;
            this.grpRandevuBilgileri.TabStop = false;
            this.grpRandevuBilgileri.Text = "Randevu Bilgileri";
            // 
            // lnkRandevuIptalEt
            // 
            this.lnkRandevuIptalEt.AutoSize = true;
            this.lnkRandevuIptalEt.Location = new System.Drawing.Point(247, 179);
            this.lnkRandevuIptalEt.Name = "lnkRandevuIptalEt";
            this.lnkRandevuIptalEt.Size = new System.Drawing.Size(87, 13);
            this.lnkRandevuIptalEt.TabIndex = 1;
            this.lnkRandevuIptalEt.TabStop = true;
            this.lnkRandevuIptalEt.Text = "Randevu İptal Et";
            this.lnkRandevuIptalEt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRandevuIptalEt_LinkClicked);
            // 
            // lnkYeniRandevu
            // 
            this.lnkYeniRandevu.AutoSize = true;
            this.lnkYeniRandevu.Location = new System.Drawing.Point(259, 21);
            this.lnkYeniRandevu.Name = "lnkYeniRandevu";
            this.lnkYeniRandevu.Size = new System.Drawing.Size(75, 13);
            this.lnkYeniRandevu.TabIndex = 0;
            this.lnkYeniRandevu.TabStop = true;
            this.lnkYeniRandevu.Text = "Yeni Randevu";
            this.lnkYeniRandevu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniRandevu_LinkClicked);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 332);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Not :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(38, 297);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Seans :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Seans :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Uzman :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(7, 234);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Son Seans Bilgileri";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(6, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Son Randevu Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Uzman :";
            // 
            // lblSeansNot
            // 
            this.lblSeansNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansNot.Location = new System.Drawing.Point(90, 331);
            this.lblSeansNot.Name = "lblSeansNot";
            this.lblSeansNot.Size = new System.Drawing.Size(244, 94);
            this.lblSeansNot.TabIndex = 3;
            // 
            // lblSeansSeans
            // 
            this.lblSeansSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansSeans.Location = new System.Drawing.Point(90, 297);
            this.lblSeansSeans.Name = "lblSeansSeans";
            this.lblSeansSeans.Size = new System.Drawing.Size(244, 23);
            this.lblSeansSeans.TabIndex = 3;
            // 
            // lblSeansUzman
            // 
            this.lblSeansUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansUzman.Location = new System.Drawing.Point(90, 265);
            this.lblSeansUzman.Name = "lblSeansUzman";
            this.lblSeansUzman.Size = new System.Drawing.Size(244, 23);
            this.lblSeansUzman.TabIndex = 3;
            // 
            // lblRandevuSeans
            // 
            this.lblRandevuSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandevuSeans.Location = new System.Drawing.Point(90, 112);
            this.lblRandevuSeans.Name = "lblRandevuSeans";
            this.lblRandevuSeans.Size = new System.Drawing.Size(244, 23);
            this.lblRandevuSeans.TabIndex = 3;
            // 
            // lblRandevuUzman
            // 
            this.lblRandevuUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandevuUzman.Location = new System.Drawing.Point(90, 81);
            this.lblRandevuUzman.Name = "lblRandevuUzman";
            this.lblRandevuUzman.Size = new System.Drawing.Size(244, 23);
            this.lblRandevuUzman.TabIndex = 3;
            // 
            // FormHastaRandevuYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 468);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.grpRandevuBilgileri);
            this.Controls.Add(this.grpArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHastaRandevuYonet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta & Randevu Yönetimi";
            this.Load += new System.EventHandler(this.FormHastaRandevuYonet_Load);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpRandevuBilgileri.ResumeLayout(false);
            this.grpRandevuBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.GroupBox grpHastaBilgileri;
        private System.Windows.Forms.GroupBox grpRandevuBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkYeniHastaGir;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.LinkLabel lnkHastaGuncelle;
        private System.Windows.Forms.LinkLabel lnkRandevuIptalEt;
        private System.Windows.Forms.LinkLabel lnkYeniRandevu;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSeansNot;
        private System.Windows.Forms.Label lblSeansSeans;
        private System.Windows.Forms.Label lblSeansUzman;
        private System.Windows.Forms.Label lblRandevuSeans;
        private System.Windows.Forms.Label lblRandevuUzman;
    }
}