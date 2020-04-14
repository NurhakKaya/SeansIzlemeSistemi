using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ISK = SISIsKatmani;
using VAR = SISVarliklar;
using VEK = SISVeriErisimKatmani;

namespace SISIsKatmani
{
    public class Seans
    {
        public static VAR.Seans[] HastaSeanslariniListele(int hastaNo)
        {
            VAR.Seans[] seanslar = null;
            seanslar = VEK.Seans.HastaSeanslariniListele(hastaNo);

            return seanslar;
        }

        public static bool NotGuncelle(int seansNo, string seansNotu)
        {
            bool sonuc = false;
            sonuc = VEK.Seans.NotGuncelle(seansNo, seansNotu);

            return sonuc;
        }

        public static bool RandevuKaydet(int seansNo, int hastaNo)
        {
            bool sonuc = false;
            sonuc = VEK.Seans.RandevuKaydet(seansNo, hastaNo);

            return sonuc;
        }
        
        public static VAR.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            VAR.Seans seans = null;
            seans = VEK.Seans.SonRandevuBilgisiGetir(hastaNo);

            return seans;
        }

        public static VAR.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            VAR.Seans seans = null;
            seans = VEK.Seans.SonSeansBilgisiGetir(hastaNo);

            return seans;
        }

        public static bool RandevuIptalEt(int seansNo)
        {
            bool sonuc = false;
            sonuc = VEK.Seans.RandevuIptalEt(seansNo);
            return sonuc;
        }
        
        public static bool IptalEt(VAR.Seans seans)
        {
            bool sonuc = false;
            sonuc = VEK.Seans.IptalEt(seans);

            return sonuc;
        }
        
        public static int Kaydet(VAR.Seans seans)
        {
            bool sonuc = false;
            bool cakismaVarMi = true;
            //önce çakışma var mı diye kontrol et
            cakismaVarMi = VEK.Seans.CakismaVarMi(seans.UzmanNo, seans.Tarih, seans.BaslangicSaati, seans.BitisSaati);

            if (cakismaVarMi)
            {
                return -1;//çakışma var.
            }

            sonuc = VEK.Seans.Kaydet(seans);

            if (sonuc)
            {
                return seans.No;
            }
            else
            {
                return 0;
            }
        }

        public static VAR.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            VAR.Seans[] seanslar = null;
            seanslar = VEK.Seans.UzmanSeanslariniListele(uzmanNo);

            return seanslar;
        }
    }
}
