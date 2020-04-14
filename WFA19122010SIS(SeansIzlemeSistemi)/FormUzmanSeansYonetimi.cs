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
    public partial class FormUzmanSeansYonetimi : Form
    {
        public FormUzmanSeansYonetimi()
        {
            InitializeComponent();
        }
        public VAR.Calisan uzman = null;
        private VAR.Hasta hasta = null;
        private VAR.Seans aktifSeans = null;
        private VAR.Seans gecmisSeans = null;

        private void UzmanSeanslariniYukle()
        {
            VAR.Seans[] seanslar = null;
            //servis çağrılıyor.
            try
            {
                seanslar = ISK.Seans.UzmanSeanslariniListele(uzman.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Seviste bir hata oluştu!");
            }
            cbbSeanslar.DataSource = seanslar;
            cbbSeanslar.DisplayMember = "GoruntuMetni";
        }
        private void BilgileriYukle()
        {
            if (hasta != null)
            {
                //hasta bilgileri yükleniyor.
                lblAd.Text = hasta.Ad;
                lblAdres.Text = hasta.Soyad;
                lblGsmNo.Text = hasta.CepTel;
                lblCinsiyet.Text = hasta.Cinsiyeti;
                lblDogumTarihi.Text = hasta.DogumTarihi.ToShortDateString();
                lblEPosta.Text = hasta.Eposta;
                lblTelefon.Text = hasta.EvTel;
                lblSoyad.Text = hasta.Soyad;
                lblTCKimlikNo.Text = hasta.TCKimlikNo;

                //aktif seans notunu yükle.
                txtAktifSeansNotu.Text = aktifSeans.SeansNotu;

                VAR.Seans[] hastaSeanslari = null;
                //hasta seans geçmişi yükleniyor.
                //servis çağrılıyor.

                try
                {
                    hastaSeanslari = ISK.Seans.HastaSeanslariniListele(hasta.No);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }
                lstSeanslar.DataSource = hastaSeanslari;
                lstSeanslar.DisplayMember = "GoruntuMetni";
            }
        }
        private bool SeansNotuKaydet(int seansNo, string seansNotu)
        {
            bool sonuc = false;

            try
            {
                sonuc = ISK.Seans.NotGuncelle(seansNo, seansNotu);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            return sonuc;
        }
        private void EkraniTemizle()
        {
            hasta = null;
            //hasta bilgisi temizleniyor.
            lblTCKimlikNo.Text = "";
            lblAd.Text = "";
            lblAdres.Text = "";
            lblGsmNo.Text = "";
            lblCinsiyet.Text = "";
            lblDogumTarihi.Text = "";
            lblEPosta.Text = "";
            lblTelefon.Text = "";
            lblSoyad.Text = "";
        }

        private void FormUzmanSeansYonetimi_Load(object sender, EventArgs e)
        {
            EkraniTemizle();

            //servis çağrılıyor.
            try
            {
                uzman = ISK.Calisan.CalisanGetir(Yardimci.KullaniciNo);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            UzmanSeanslariniYukle();
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            EkraniTemizle();

            aktifSeans = (VAR.Seans)cbbSeanslar.SelectedItem;

            if (aktifSeans.HastaNo>0)
            {
                //servis çağrılıyor.
                try
                {
                    hasta = ISK.Hasta.HastaGetir(aktifSeans.HastaNo);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }
            }
            BilgileriYukle();
        }

        private void brnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGecmisSeansNotu.Text))
            {
                MessageBox.Show("Eski seans için seans notu giriniz.");
                txtGecmisSeansNotu.Focus();
                return;
            }
            bool sonuc = SeansNotuKaydet(gecmisSeans.No, txtGecmisSeansNotu.Text);
            if (sonuc)
            {
                MessageBox.Show("Eski seans notu güncellendi.");
                gecmisSeans.SeansNotu = txtGecmisSeansNotu.Text;
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAktifSeansNotu.Text))
            {
                MessageBox.Show("Aktif seans için seans notu giriniz.");
                txtAktifSeansNotu.Focus();
                return;
            }
            bool sonuc = SeansNotuKaydet(aktifSeans.No, txtAktifSeansNotu.Text);
            if (sonuc)
            {
                MessageBox.Show("Yeni seans notu kaydedildi.");
                aktifSeans.SeansNotu = txtAktifSeansNotu.Text;
                EkraniTemizle();
                UzmanSeanslariniYukle();
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi.");
            }
        }

        private void lstSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gecmisSeans = (VAR.Seans)lstSeanslar.SelectedItem;
            if (gecmisSeans != null)
            {
                txtGecmisSeansNotu.Text = gecmisSeans.SeansNotu;
            }
        }
    }
}
