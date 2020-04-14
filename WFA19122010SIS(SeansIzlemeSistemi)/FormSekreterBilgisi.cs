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
    public partial class FormSekreterBilgisi : Form
    {
        public FormSekreterBilgisi()
        {
            InitializeComponent();
        }
        public VAR.Calisan calisan;
        private void UzmanYukle()
        {
            txtAd.Text = calisan.Ad;
            txtEPosta.Text = calisan.Eposta;
            txtGsmNo.Text = calisan.CepTel;
            txtKimlikNo.Text = calisan.TCKimlikNo;
            txtSoyad.Text = calisan.Soyad;
            txtTelefon.Text = calisan.EvTel;
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Ad bilgisini boş geçemezsiniz.");
                txtAd.SelectAll();
                txtAd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Soyad bilgisini boş geçemezsiniz.");
                txtSoyad.SelectAll();
                txtSoyad.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEPosta.Text))
            {
                MessageBox.Show("EPosta bilgisini boş geçemezsiniz.");
                txtEPosta.SelectAll();
                txtEPosta.Focus();
                return false;
            }
            return true;
        }

        private void FormSekreterBilgisi_Load(object sender, EventArgs e)
        {
            if (calisan!=null)
            {
                UzmanYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            if (!dogruMu)
            {
                return;
            }
            //yeni kayıtsa, yeni bir calışan nesnesi olusturuluyor.
            if (calisan==null)
            {
                calisan = new SISVarliklar.Calisan();
            }

            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.TCKimlikNo = txtKimlikNo.Text;
            calisan.CalisanTipi = VAR.Calisan.CalisanTipleri.Sekreter;
            calisan.CepTel = txtGsmNo.Text;
            calisan.Eposta = txtEPosta.Text;
            calisan.EvTel = txtTelefon.Text;

            int sonuc = 0;
            //servis çağrılıyor.
            try
            {
                sonuc = ISK.Calisan.Kaydet(calisan);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }

        //private void FormSekreterBilgisi_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{

        //}
    }
}
