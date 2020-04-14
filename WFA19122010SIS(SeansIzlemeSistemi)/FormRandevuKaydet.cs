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
    public partial class FormRandevuKaydet : Form
    {
        public FormRandevuKaydet()
        {
            InitializeComponent();
        }
        public VAR.Hasta hasta;
        private VAR.Calisan uzman;
        private VAR.Seans seans;

        private void UzmanlariYukle()
        {
            VAR.Calisan[] calisanlar = null;
            //servis çağrılıyor.
            try
            {
                calisanlar = ISK.Calisan.UzmanlariListele();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            cbbUzmanlar.DataSource = calisanlar;
            cbbUzmanlar.DisplayMember = "GoruntuMetni";
        }

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
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            cbbSeanslar.DataSource = seanslar;
            cbbSeanslar.DisplayMember = "GoruntuMetni";
        }

        private bool KullaniciGirdisiDogrula()
        {
            if (uzman==null)
            {
                MessageBox.Show("Uzman bilgisini boş geçemezsiniz.");
                cbbUzmanlar.Focus();
                return false;
            }
            if (seans==null)
            {
                MessageBox.Show("Seans bilgisini boş geçemezsiniz.");
                cbbSeanslar.Focus();
                return false;
            }
            return true;
        }

        private void FormRandevuKaydet_Load(object sender, EventArgs e)
        {
            lblHasta.Text = hasta.GoruntuMetni;
            UzmanlariYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            bool sonuc = false;

            if (!dogruMu)
            {
                return;
            }
            //servis çağrılıyor.
            try
            {
                seans.HastaNo = hasta.No;
                sonuc = ISK.Seans.RandevuKaydet(seans.No, hasta.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            if (sonuc)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            uzman = (VAR.Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (VAR.Seans)cbbSeanslar.SelectedItem;
        }
    }
}
