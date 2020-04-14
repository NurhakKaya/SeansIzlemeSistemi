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
    public partial class FormSeansYonetimi : Form
    {
        public FormSeansYonetimi()
        {
            InitializeComponent();
        }

        VAR.Calisan uzman = null;

        private void FormSeansYonetimi_Load(object sender, EventArgs e)
        {
            UzmanlariYukle();
        }

        private void UzmanlariYukle()
        {
            VAR.Calisan[] uzmanlar = null;
            // servis çağırılıyor
            try
            {
                uzmanlar = ISK.Calisan.UzmanlariListele();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            cbbUzmanlar.DataSource = uzmanlar;
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
                MessageBox.Show("Seviste bir hata oluştu!");
            }
            lstSeanslar.DataSource = seanslar;
            lstSeanslar.DisplayMember = "GoruntuMetni";

            if (lstSeanslar.Items.Count > 0 && lstSeanslar.SelectedIndex > -1)
            {
                lnkSeansIptalEt.Enabled = true;
            }
            else
            {
                lnkSeansIptalEt.Enabled = false;
            }
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uzman = (VAR.Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void lnkSeansEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYeniSeans frm = new FormYeniSeans();
            frm.uzman = this.uzman;
            frm.ShowDialog();
            UzmanSeanslariniYukle();
        }

        private void lnkSeansIptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VAR.Seans seans = (VAR.Seans)lstSeanslar.SelectedItem;

            FormSeansIptalEt frm = new FormSeansIptalEt();
            frm.seans = seans;
            frm.ShowDialog();
            UzmanSeanslariniYukle();
        }
    }
}
