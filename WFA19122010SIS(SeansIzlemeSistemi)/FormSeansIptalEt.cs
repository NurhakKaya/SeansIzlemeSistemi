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
    public partial class FormSeansIptalEt : Form
    {
        public FormSeansIptalEt()
        {
            InitializeComponent();
        }

        public VAR.Seans seans;
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtIptalNedeni.Text))
            {
                MessageBox.Show("İptal nedenini boş geçemezsiniz.");
                txtIptalNedeni.SelectAll();
                txtIptalNedeni.Focus();
                return false;
            }
            return true;
        }

        private void FormSeansIptalEt_Load(object sender, EventArgs e)
        {
            lblUzman.Text = seans.UzmanBilgisi;
            lblSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Program.KullaniciNo;
            
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            bool sonuc = false;
            //servis çağrılıyor.
            try
            {
                sonuc = ISK.Seans.IptalEt(seans);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc)
            {
                MessageBox.Show("Seans iptal edildi.");
            }
            else
            {
                MessageBox.Show("Oluşan bir hata nedeniyle seans iptal edilemedi!");
            }
            this.Close();
        }
    }
}
