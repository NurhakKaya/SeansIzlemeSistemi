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
    public partial class FormHastaBilgisi : Form
    {
        public FormHastaBilgisi()
        {
            InitializeComponent();
        }
        public VAR.Hasta hasta;
        private void HastaYukle()
        {
            txtAd.Text = hasta.Ad;
            txtEPosta.Text = hasta.Eposta;
            txtGsmNo.Text = hasta.CepTel;
            txtKimlikNo.Text = hasta.TCKimlikNo;
            txtSoyad.Text = hasta.Soyad;
            txtTelefon.Text = hasta.EvTel;
            cbbCinsiyet.Text = hasta.Cinsiyeti;
            dtpDogumTarihi.Value = hasta.DogumTarihi;
            txtAdres.Text = hasta.Adres;
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
            return true;
        }

        private void FormHastaBilgisi_Load(object sender, EventArgs e)
        {
            dtpDogumTarihi.Value = DateTime.Now;
            cbbCinsiyet.SelectedIndex = 0;
            if (hasta!=null)
            {
                HastaYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            if (!dogruMu)
            {
                return;
            }
            // yeni kayıtsa, yeni bir calisan nesnesi oluşturuluyor.
            if (hasta==null)
            {
                hasta = new SISVarliklar.Hasta();
            }

            hasta.Ad = txtAd.Text;
            hasta.Adres = txtAdres.Text;
            hasta.CepTel = txtGsmNo.Text;
            hasta.Cinsiyeti = cbbCinsiyet.Items[cbbCinsiyet.SelectedIndex].ToString();
            hasta.DogumTarihi = dtpDogumTarihi.Value;
            hasta.Eposta = txtEPosta.Text;
            hasta.EvTel = txtTelefon.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TCKimlikNo = txtKimlikNo.Text;

            int sonuc = 0;
            
            //servis çağrılıyor.
            try
            {
                sonuc = ISK.Hasta.Kaydet(hasta);
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
    }
}
