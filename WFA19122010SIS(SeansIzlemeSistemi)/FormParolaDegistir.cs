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
    public partial class FormParolaDegistir : Form
    {
        public FormParolaDegistir()
        {
            InitializeComponent();
        }

        public VAR.Calisan calisan;
        private bool KullanciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtEski.Text))
            {
                MessageBox.Show("Eski parola bilgisini boş geçemezsiniz.");
                txtEski.SelectAll();
                txtEski.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtYeni1.Text))
            {
                MessageBox.Show("Yeni parola bilgisini boş geçemezsiniz.");
                txtYeni1.SelectAll();
                txtYeni1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtYeni2.Text))
            {
                MessageBox.Show("Yeni parola tekrarını boş geçemezsiniz.");
                txtYeni2.SelectAll();
                txtYeni2.Focus();
                return false;
            }
            if (txtYeni1.Text!=txtYeni2.Text)
            {
                MessageBox.Show("Yeni parola ve tekrarı aynı olmalı.");
                txtYeni2.SelectAll();
                txtYeni2.Focus();
                return false;
            }
            return true;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanciGirdisiDogrula();
            if (!dogruMu)
            {
                return;
            }

            //servis çağrılıyor.
            bool sonuc = false;
            try
            {
                sonuc = ISK.Calisan.ParolaDegistir(calisan.No, txtYeni1.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc)
            {
                MessageBox.Show("Parola değiştirildi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilirken bir hata oluştu!");
            }
        }
    }
}
