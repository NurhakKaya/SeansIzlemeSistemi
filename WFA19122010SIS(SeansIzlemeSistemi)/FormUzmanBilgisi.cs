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
    public partial class FormUzmanBilgisi : Form
    {
        public FormUzmanBilgisi()
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
            txtUnvan.Text = calisan.Unvan;
        }
        private bool KullaniciBilgisiDogrula()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Ad bilgisini boş geçemezsiniz");
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

        private void FormUzmanBilgisi_Load(object sender, EventArgs e)
        {
            if (calisan != null)
            {
                UzmanYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciBilgisiDogrula();
            if (!dogruMu)
            {
                return;
            }
            //yeni kayıtsa, yeni bir calisan nesnesi oluşturuluyor.
            if (calisan == null)
            {
                calisan = new SISVarliklar.Calisan();
            }
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.TCKimlikNo = txtKimlikNo.Text;
            calisan.Unvan = txtUnvan.Text;
            calisan.CalisanTipi = SISVarliklar.Calisan.CalisanTipleri.Uzman;
            calisan.CepTel = txtGsmNo.Text;
            calisan.Eposta = txtEPosta.Text;
            calisan.EvTel = txtTelefon.Text;

            int sonuc = 0;
            //servis çağırılıyor.
            try
            {
                sonuc = ISK.Calisan.Kaydet(calisan);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }
    }
}
