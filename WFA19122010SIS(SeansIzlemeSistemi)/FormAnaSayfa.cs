using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ISK = SISIsKatmani;
using VAR = SISVarliklar;


namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    public partial class FormAnaSayfa : Form
    {
        public VAR.Calisan calisan = null;
        public FormAnaSayfa()
        {
            InitializeComponent();

        }

        private void SaatYaz()
        {
            tsiSaat.Text = DateTime.Now.ToLongTimeString();
            tsiTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void MenuYukle()
        {
            mniCikis.Visible = true;
            mniParolaDegistir.Visible = true;
            mniCalisanAra.Visible = false;
            mniParolaSifirla.Visible = false;
            mniRandevuYonet.Visible = false;
            mniSeansYonetSekreter.Visible = false;
            mniSeansYonetUzman.Visible = false;
            mniSekreterKaydet.Visible = false;
            mniUzmanKaydet.Visible = false;
            

            switch (calisan.CalisanTipi)
            {
                case VAR.Calisan.CalisanTipleri.SistemYoneticisi:
                    mniSekreterKaydet.Visible = true;
                    mniParolaSifirla.Visible = true;
                    tsiKullanici.Text += " (Sistem Yöneticisi)";
                    break;
                case VAR.Calisan.CalisanTipleri.Sekreter:
                    mniRandevuYonet.Visible = true;
                    mniSeansYonetSekreter.Visible = true;
                    mniUzmanKaydet.Visible = true;
                    mniCalisanAra.Visible = true;
                    tsiKullanici.Text += " (Sekreter)";
                    break;
                case VAR.Calisan.CalisanTipleri.Uzman:
                    mniSeansYonetUzman.Visible = true;
                    tsiKullanici.Text += " (Uzman)";
                    break;
                default:
                    break;            
            }
        }

        private void mniParolaDegistir_Click(object sender, EventArgs e)
        {
            FormParolaDegistir frm = new FormParolaDegistir();
            frm.calisan = this.calisan;
            frm.ShowDialog();

        }

        private void mniParolaSifirla_Click(object sender, EventArgs e)
        {
            FormParolaSifirla frm = new FormParolaSifirla();
            frm.ShowDialog();
        }

        private void mniUzmanKaydet_Click(object sender, EventArgs e)
        {
            FormUzmanBilgisi frm = new FormUzmanBilgisi();
            frm.ShowDialog();
        }

        private void mniSekreterKaydet_Click(object sender, EventArgs e)
        {
            FormSekreterBilgisi frm = new FormSekreterBilgisi();
            frm.ShowDialog();
        }

        private void mniCalisanAra_Click(object sender, EventArgs e)
        {
            FormCalisanArama frm = new FormCalisanArama();
            frm.ShowDialog();
        }

        private void mniRandevuYonet_Click(object sender, EventArgs e)
        {
            FormHastaRandevuYonet frm = new FormHastaRandevuYonet();
            frm.ShowDialog();
        }

        private void mniSeansYonetSekreter_Click(object sender, EventArgs e)
        {
            FormSeansYonetimi frm = new FormSeansYonetimi();
            frm.ShowDialog();
        }

        private void mniSeansYonetUzman_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYonetimi frm = new FormUzmanSeansYonetimi();
            frm.ShowDialog();
        }

        private void mniCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            //Hata kaydet test ediliyor.
            Yardimci.HataKaydet(new Exception("Hata kaydet testi."));
            //giriş sayfası çağırılıyor.
            this.Hide();
            FormGiris frm = new FormGiris();
            frm.ShowDialog(this);

            if (Yardimci.KullaniciNo>0)
            {
                //saat yazdırılıyor.
                SaatYaz();

                //servis çağırılıyor.
                try
                {
                    calisan = ISK.Calisan.CalisanGetir(Yardimci.KullaniciNo);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }

                //kullanıcı bilgisi durum çubuğunda görüntüleniyor.
                tsiKullanici.Text = calisan.GoruntuMetni;

                MenuYukle(); //menü yükleniyor.
            }
            else
            {
                this.Close();
            }

            //SaatYaz();
        }

        
    }
}

