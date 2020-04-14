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
    public partial class FormParolaSifirla : Form
    {
        public FormParolaSifirla()
        {
            InitializeComponent();
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtEPosta.Text))
            {
                MessageBox.Show("EPosta bilgisini boş geçemezsiniz.");
                txtEPosta.SelectAll();
                txtEPosta.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Yeni parola bilgisini boş geçemezsiniz.");
                txtParola.SelectAll();
                txtParola.Focus();
                return false;
            }
            return true;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            if (!dogruMu)
            {
                return;
            }
            //servis çağrılıyor.
            bool sonuc = false;
            try
            {
                sonuc = ISK.Calisan.ParolaSifirla(txtEPosta.Text, txtParola.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc)
            {
                MessageBox.Show("Parola sıfırlandı.");
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilirken bir hata oluştu!");
            }
        }
    }
}
