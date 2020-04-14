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
    public partial class FormCalisanArama : Form
    {
        public FormCalisanArama()
        {
            InitializeComponent();
        }
        private void CalisanlariListele()
        {
            VAR.Calisan[] calisanlar = null;    
            lstCalisanlar.DisplayMember = "GoruntuMetni";
            //servis çağrılıyor.
            try
            {
                calisanlar = ISK.Calisan.CalisanlariListele(txtAd.Text, txtSoyad.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            finally
            {
                lstCalisanlar.DataSource = calisanlar;
            }
        }

        private void lstCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            int indeks = lstCalisanlar.SelectedIndex;

            VAR.Calisan calisan = (VAR.Calisan)lstCalisanlar.SelectedItem;
            if (calisan.CalisanTipi==VAR.Calisan.CalisanTipleri.Sekreter)
            {
                FormSekreterBilgisi frm = new FormSekreterBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }
            else if (calisan.CalisanTipi==VAR.Calisan.CalisanTipleri.Uzman)
            {
                FormUzmanBilgisi frm = new FormUzmanBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }
            CalisanlariListele();
            lstCalisanlar.SelectedIndex = indeks;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CalisanlariListele();
        }
    }
}
