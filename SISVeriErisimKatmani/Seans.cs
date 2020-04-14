using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VAR = SISVarliklar;
using System.Data.SqlClient;
using System.Data;

namespace SISVeriErisimKatmani
{
    public class Seans
    {
        public static SISVarliklar.Seans[] HastaSeanslariniListele(int hastaNo)
        {
            string spAdi = "prSeansHastaSeanslariniListele";
            List<VAR.Seans> seanslar = new List<VAR.Seans>();

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                VAR.Seans seans = SeansBilgileriYukle(sdr);
                seanslar.Add(seans);
            }
            sdr.Close();
            k.Temizle();

            return seanslar.ToArray();
        }

        public static bool NotGuncelle(int seansNo, string seansNotu)
        {
            string spAdi = "prSeansNotuGuncelle";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seansNo);
            k.ParametreEkle("@seansNotu", seansNotu);

            etkilenen = k.Islet();

            k.Temizle();
            return etkilenen > 0;
        }

        public static bool RandevuKaydet(int seansNo, int hastaNo)
        {
            string spAdi = "prSeansRandevuKaydet";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seansNo);
            k.ParametreEkle("@hastaNo", hastaNo);
            etkilenen = k.Islet();

            k.Temizle();
            return etkilenen > 0;
        }

        public static SISVarliklar.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            string spAdi = "prSeansHastaSonRandevuBilgisiGetir";
            VAR.Seans seans = null;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                seans = SeansBilgileriYukle(sdr);
            }
            sdr.Close();
            k.Temizle();

            return seans;
        }

        public static SISVarliklar.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            string spAdi = "prSeansHastaSonSeansBilgisiGetir";
            VAR.Seans seans = null;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                seans = SeansBilgileriYukle(sdr);
            }
            sdr.Close();
            k.Temizle();

            return seans;
        }

        public static bool RandevuIptalEt(int seansNo)
        {
            string spAdi = "prSeansRandevuIptalEt";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seansNo);

            etkilenen = k.Islet();

            k.Temizle();
            return etkilenen > 0;
        }

        public static bool IptalEt(VAR.Seans seans)
        {
            string spAdi = "prSeansIptalEt";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seans.No);
            k.ParametreEkle("@iptalEdenNo", seans.IptalEdenNo);
            k.ParametreEkle("@iptalNotu", seans.IptalNotu);
            k.ParametreEkle("@hastaIptalEtti", seans.HastaIptalEtti);

            etkilenen = k.Islet();

            k.Temizle();
            return etkilenen > 0;
        }

        public static bool CakismaVarMi(int uzmanNo, DateTime tarih, string baslangicSaati, string bitisSaati)
        {
            string spAdi = "prSeansCakisanSeansSayisi";
            int cakisan = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", uzmanNo);
            k.ParametreEkle("@tarih", tarih);
            k.ParametreEkle("@baslangicSaati", baslangicSaati);
            k.ParametreEkle("@bitisSaati", bitisSaati);

            cakisan = k.Islet();

            k.Temizle();
            return cakisan > 0;
        }

        public static bool Kaydet(SISVarliklar.Seans seans)
        {
            string spAdi = "prSeansYeniKaydet";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", seans.UzmanNo);
            k.ParametreEkle("@tarih", seans.Tarih);
            k.ParametreEkle("@baslangicSaati", seans.BaslangicSaati);
            k.ParametreEkle("@bitisSaati", seans.BitisSaati);
            k.ParemetreEkleOut("@seansNo", SqlDbType.Int, 0);

            etkilenen = k.Islet();
            if (etkilenen > 0)
            {
                seans.No = k.OutParametreDegeriGetir("@seansNo");
            }

            k.Temizle();
            return etkilenen > 0;
        }

        public static SISVarliklar.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            string spAdi = "prSeansUzmanSeanslariniListele";
            List<VAR.Seans> seanslar = new List<VAR.Seans>();

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", uzmanNo);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                VAR.Seans seans = SeansBilgileriYukle(sdr);
                seanslar.Add(seans);
            }
            sdr.Close();
            k.Temizle();

            return seanslar.ToArray();
        }

        public static VAR.Seans SeansBilgileriYukle(SqlDataReader sdr)
        {
            VAR.Seans seans = new VAR.Seans();
            seans.BaslangicSaati = Komut.StringGetir(sdr, "BaslangicSaati");
            seans.BitisSaati = Komut.StringGetir(sdr, "BitisSaati");
            seans.HastaNo = Komut.Int32Getir(sdr, "HastaNo");
            seans.IptalEdenNo = Komut.Int32Getir(sdr, "IptalEdenNo");
            seans.IptalNotu = Komut.StringGetir(sdr, "IptalNotu");
            seans.No = Komut.Int32Getir(sdr, "SeansNo");
            seans.SeansNotu = Komut.StringGetir(sdr, "SeansNotu");
            seans.Tarih = Komut.TarihGetir(sdr, "Tarih");
            seans.UzmanNo = Komut.Int32Getir(sdr, "UzmanNo");
            seans.UzmanBilgisi = Komut.StringGetir(sdr, "UzmanBilgisi");
            seans.HastaBilgisi = Komut.StringGetir(sdr, "HastaBilgisi");
            seans.HastaIptalEtti = Komut.BoolGetir(sdr, "HastaIptalEtti");

            return seans;
        }
    }
}
