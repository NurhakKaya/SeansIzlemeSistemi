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
    public partial class FormYeniSeans : Form
    {
        public FormYeniSeans()
        {
            InitializeComponent();
        }

        public VAR.Calisan uzman = null;
        private const int enKisaSeansSuresi = 30;

        private bool KullanciGirdisiDogrula()
        {
            if (dtpBaslangicSaati.Value>dtpBitisSaati.Value)
            {
                MessageBox.Show("Bitiş saati başlangıç saatinden önce olamaz.");
                dtpBaslangicSaati.Focus();
                return false;
            }
            double seansSuresi = dtpBitisSaati.Value.Subtract(dtpBaslangicSaati.Value).TotalMinutes;
            if (seansSuresi<enKisaSeansSuresi)
            {
                MessageBox.Show("Seans süresi 30 dakikadan az olamaz.");
                dtpBitisSaati.Focus();
                return false;
            }
            return true;
        }

        private void FormYeniSeans_Load(object sender, EventArgs e)
        {
            lblUzman.Text = uzman.GoruntuMetni;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanciGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            VAR.Seans seans = new SISVarliklar.Seans();

            seans.UzmanNo = uzman.No;
            seans.Tarih = dtpTarih.Value;
            seans.BaslangicSaati = dtpBaslangicSaati.Value.ToShortTimeString();
            seans.BitisSaati = dtpBitisSaati.Value.ToShortTimeString();

            int sonuc = 0;

            //servis çağrılıyor.
            try
            {
                sonuc = ISK.Seans.Kaydet(seans);
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
            else if (sonuc==-1)
            {
                MessageBox.Show("Seans saatlerinde çakışma var!");
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }
    }
}
