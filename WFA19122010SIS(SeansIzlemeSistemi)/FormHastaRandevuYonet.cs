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
    public partial class FormHastaRandevuYonet : Form
    {
        public FormHastaRandevuYonet()
        {
            InitializeComponent();
        }

        public VAR.Hasta hasta = null;
        private VAR.Seans sonRandevu = null;
        private VAR.Seans sonSeans = null;

        private void FormHastaRandevuYonet_Load(object sender, EventArgs e)
        {
            HastaBilgisiTemizle();
            RandevuBilgisiTemizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void HastalariListele()
        {
            lstHastalar.DisplayMember = "GoruntuMetni";
            VAR.Hasta[] hastalar = null;

            //servis çağrılıyor.
            try
            {
                hastalar = ISK.Hasta.HastalariListele(txtAd.Text, txtSoyad.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            finally
            {
                lstHastalar.DataSource = hastalar;
            }
        }

        private void HastaBilgisiYukle()
        {
            HastaBilgisiTemizle();

            lblAd.Text = hasta.Ad;
            lblAdres.Text = hasta.Adres;
            lblCinsiyet.Text = hasta.Cinsiyeti;
            lblGsmNo.Text = hasta.CepTel;
            lblDogumTarihi.Text = hasta.DogumTarihi.ToShortDateString();
            lblEPosta.Text = hasta.Eposta;
            lblTelefon.Text = hasta.EvTel;
            lblSoyad.Text = hasta.Soyad;
            lblTCKimlikNo.Text = hasta.TCKimlikNo;
        }

        private void RandevuBilgisiYukle()
        {
            RandevuBilgisiTemizle();
            //servis çağrılıyor.
            try
            {
                sonRandevu = ISK.Seans.SonRandevuBilgisiGetir(hasta.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            if (sonRandevu!=null)
            {
                lblRandevuSeans.Text = sonRandevu.GoruntuMetni;
                lblRandevuUzman.Text = sonRandevu.UzmanBilgisi;
                lnkRandevuIptalEt.Enabled = true;
            }
            else
            {
                lnkYeniRandevu.Enabled = true;
            }
            //servis çağrılıyor.
            try
            {
                sonSeans = ISK.Seans.SonSeansBilgisiGetir(hasta.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonSeans!=null)
            {
                lblSeansUzman.Text = sonSeans.UzmanBilgisi;
                lblSeansSeans.Text = sonSeans.GoruntuMetni;
                lblSeansNot.Text = sonSeans.SeansNotu;
            }
        }
        
        private void HastaBilgisiTemizle()
        {
            lblAd.Text = "";
            lblAdres.Text = "";
            lblCinsiyet.Text = "";
            lblDogumTarihi.Text = "";
            lblEPosta.Text = "";
            lblGsmNo.Text = "";
            lblTelefon.Text = "";
            lblSoyad.Text = "";
            lblTCKimlikNo.Text = "";
        }

        private void RandevuBilgisiTemizle()
        {
            lblRandevuSeans.Text = "";
            lblRandevuUzman.Text = "";

            lblSeansNot.Text = "";
            lblSeansSeans.Text = "";
            lblSeansUzman.Text = "";

            lnkYeniRandevu.Enabled = false;
            lnkRandevuIptalEt.Enabled = false;
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasta = (VAR.Hasta)lstHastalar.Items[lstHastalar.SelectedIndex];
            HastaBilgisiYukle();
            RandevuBilgisiYukle();
        }

        private void lnkHastaGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int indeks = lstHastalar.SelectedIndex;

            FormHastaBilgisi frm = new FormHastaBilgisi();
            frm.hasta = this.hasta;
            frm.ShowDialog();

            HastalariListele();
            lstHastalar.SelectedIndex = indeks;
        }

        private void lnkYeniHastaGir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //burası da bug olabilir.
            FormHastaBilgisi frm = new FormHastaBilgisi();
            DialogResult cevap = frm.ShowDialog();
            if (cevap==DialogResult.OK)
            {
                txtAd.Text = frm.hasta.Ad;
                txtSoyad.Text = frm.hasta.Soyad;
                HastalariListele();
                if (lstHastalar.Items.Count>0)
                {
                    lstHastalar.SelectedIndex = 0;
                }
            }
        }
        
        private void lnkYeniRandevu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRandevuKaydet frm = new FormRandevuKaydet();
            frm.hasta = this.hasta;
            frm.ShowDialog();

            RandevuBilgisiYukle();
        }

        private void lnkRandevuIptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mesaj = "Randevuyu iptal etmek istediğinizden emin misiniz?";
            DialogResult karar = MessageBox.Show(mesaj, "İptal Onayı",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (karar==DialogResult.Yes)
            {
                bool sonuc = false;
                //servis çağrılıyor.
                try
                {
                    sonuc = ISK.Seans.RandevuIptalEt(sonRandevu.No);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }
                if (sonuc)
                {
                    RandevuBilgisiYukle();
                }
            }
        }
    }
}
