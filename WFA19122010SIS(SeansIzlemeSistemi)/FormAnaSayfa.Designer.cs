namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    partial class FormAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaSifirla = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUzmanKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSekreterKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCalisanAra = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandevuYonet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansYonetSekreter = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansYonetUzman = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsiKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniMenu
            // 
            this.mniMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniParolaDegistir,
            this.mniParolaSifirla,
            this.mniUzmanKaydet,
            this.mniSekreterKaydet,
            this.mniCalisanAra,
            this.mniRandevuYonet,
            this.mniSeansYonetSekreter,
            this.mniSeansYonetUzman,
            this.mniCikis});
            this.mniMenu.Name = "mniMenu";
            this.mniMenu.Size = new System.Drawing.Size(50, 20);
            this.mniMenu.Text = "&Menü";
            // 
            // mniParolaDegistir
            // 
            this.mniParolaDegistir.Name = "mniParolaDegistir";
            this.mniParolaDegistir.Size = new System.Drawing.Size(200, 22);
            this.mniParolaDegistir.Text = "Parola &Değiştir";
            this.mniParolaDegistir.Click += new System.EventHandler(this.mniParolaDegistir_Click);
            // 
            // mniParolaSifirla
            // 
            this.mniParolaSifirla.Name = "mniParolaSifirla";
            this.mniParolaSifirla.Size = new System.Drawing.Size(200, 22);
            this.mniParolaSifirla.Text = "Par&ola Sıfırla";
            this.mniParolaSifirla.Click += new System.EventHandler(this.mniParolaSifirla_Click);
            // 
            // mniUzmanKaydet
            // 
            this.mniUzmanKaydet.Name = "mniUzmanKaydet";
            this.mniUzmanKaydet.Size = new System.Drawing.Size(200, 22);
            this.mniUzmanKaydet.Text = "&Uzman Kaydet";
            this.mniUzmanKaydet.Click += new System.EventHandler(this.mniUzmanKaydet_Click);
            // 
            // mniSekreterKaydet
            // 
            this.mniSekreterKaydet.Name = "mniSekreterKaydet";
            this.mniSekreterKaydet.Size = new System.Drawing.Size(200, 22);
            this.mniSekreterKaydet.Text = "&Sekreter Kaydet";
            this.mniSekreterKaydet.Click += new System.EventHandler(this.mniSekreterKaydet_Click);
            // 
            // mniCalisanAra
            // 
            this.mniCalisanAra.Name = "mniCalisanAra";
            this.mniCalisanAra.Size = new System.Drawing.Size(200, 22);
            this.mniCalisanAra.Text = "Çalışan &Ara";
            this.mniCalisanAra.Click += new System.EventHandler(this.mniCalisanAra_Click);
            // 
            // mniRandevuYonet
            // 
            this.mniRandevuYonet.Name = "mniRandevuYonet";
            this.mniRandevuYonet.Size = new System.Drawing.Size(200, 22);
            this.mniRandevuYonet.Text = "Hasta && &Randevu Yönet";
            this.mniRandevuYonet.Click += new System.EventHandler(this.mniRandevuYonet_Click);
            // 
            // mniSeansYonetSekreter
            // 
            this.mniSeansYonetSekreter.Name = "mniSeansYonetSekreter";
            this.mniSeansYonetSekreter.Size = new System.Drawing.Size(200, 22);
            this.mniSeansYonetSekreter.Text = "&Seans Yönet Sekreter";
            this.mniSeansYonetSekreter.Click += new System.EventHandler(this.mniSeansYonetSekreter_Click);
            // 
            // mniSeansYonetUzman
            // 
            this.mniSeansYonetUzman.Name = "mniSeansYonetUzman";
            this.mniSeansYonetUzman.Size = new System.Drawing.Size(200, 22);
            this.mniSeansYonetUzman.Text = "&Seans Yönet Uzman";
            this.mniSeansYonetUzman.Click += new System.EventHandler(this.mniSeansYonetUzman_Click);
            // 
            // mniCikis
            // 
            this.mniCikis.Name = "mniCikis";
            this.mniCikis.Size = new System.Drawing.Size(200, 22);
            this.mniCikis.Text = "&Çıkış";
            this.mniCikis.Click += new System.EventHandler(this.mniCikis_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiKullanici,
            this.tsiTarih,
            this.tsiSaat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsiKullanici
            // 
            this.tsiKullanici.Name = "tsiKullanici";
            this.tsiKullanici.Size = new System.Drawing.Size(320, 17);
            this.tsiKullanici.Spring = true;
            this.tsiKullanici.Text = "Nurhak Kaya (Sistem Yöneticisi)";
            // 
            // tsiTarih
            // 
            this.tsiTarih.Name = "tsiTarih";
            this.tsiTarih.Size = new System.Drawing.Size(131, 17);
            this.tsiTarih.Text = "1 Nisan 2010, Perşembe";
            // 
            // tsiSaat
            // 
            this.tsiSaat.Name = "tsiSaat";
            this.tsiSaat.Size = new System.Drawing.Size(34, 17);
            this.tsiSaat.Text = "23:23";
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA19122010SIS_SeansIzlemeSistemi_.Properties.Resources.dosyalar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 401);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans İzleme Sistemi Ana Sayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniMenu;
        private System.Windows.Forms.ToolStripMenuItem mniParolaDegistir;
        private System.Windows.Forms.ToolStripMenuItem mniParolaSifirla;
        private System.Windows.Forms.ToolStripMenuItem mniUzmanKaydet;
        private System.Windows.Forms.ToolStripMenuItem mniSekreterKaydet;
        private System.Windows.Forms.ToolStripMenuItem mniCalisanAra;
        private System.Windows.Forms.ToolStripMenuItem mniRandevuYonet;
        private System.Windows.Forms.ToolStripMenuItem mniSeansYonetSekreter;
        private System.Windows.Forms.ToolStripMenuItem mniSeansYonetUzman;
        private System.Windows.Forms.ToolStripMenuItem mniCikis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsiKullanici;
        private System.Windows.Forms.ToolStripStatusLabel tsiTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsiSaat;
        private System.Windows.Forms.Timer tmrSaat;
    }
}