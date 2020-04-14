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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            //kullanıcı girişi doğrulama
            if (string.IsNullOrEmpty(txtKullanici.Text))
            {
                MessageBox.Show("Kullanıcı bilgisini boş geçemezsiniz.");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz.");
                txtParola.SelectAll();
                txtParola.Focus();
                return;	 
	        }
            int calisanNo=0;
            //servis çağrılıyor.
            try 
	        {	        
		        calisanNo=ISK.Calisan.KullaniciGirisiniDogrula(txtKullanici.Text, txtParola.Text);
	        }
	        catch (Exception ex)
	        {
		        Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu.");
	        }
            if (calisanNo>0)
	        {
                Yardimci.KullaniciNo=calisanNo;
                this.Close();
	        }
            else
	        {
                MessageBox.Show("Hatalı kullanıcı/Parola bilgisi!");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
	        }
        }
    }
}
