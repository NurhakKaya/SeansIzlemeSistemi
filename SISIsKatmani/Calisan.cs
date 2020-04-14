using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VEK = SISVeriErisimKatmani;
using VAR = SISVarliklar;

namespace SISIsKatmani
{
    public class Calisan
    {
        public static bool ParolaSifirla(string ePosta, string parola)
        {
            bool sonuc = false;
            sonuc = VEK.Calisan.ParolaSifirla(ePosta, parola);
            return sonuc;
        }
        
        public static bool ParolaDegistir(int calisanNo, string yeniParola)
        {
            bool sonuc = false;
            sonuc = VEK.Calisan.ParolaDegistir(calisanNo, yeniParola);

            return sonuc;
        }

        public static VAR.Calisan[] CalisanlariListele(string ad, string soyad)
        {
            VAR.Calisan[] calisanlar = null;
            calisanlar = VEK.Calisan.CalisanlariListele(ad, soyad);
            return calisanlar;
        }

        public static VAR.Calisan[] UzmanlariListele()
        {
            VAR.Calisan[] calisanlar = null;
            calisanlar = VEK.Calisan.UzmanlariListele();

            return calisanlar;
        }

        public static int Kaydet(VAR.Calisan calisan)
        {
            bool sonuc = false;
            if (calisan.No>0)
            {
                sonuc = VEK.Calisan.Guncelle(calisan);
            }
            else
            {
                calisan.Parola = Yardimci.ParolaOlustur();
                sonuc = VEK.Calisan.Kaydet(calisan);
            }
            if (sonuc)
            {
                //yeni parolayı email yolla
                Yardimci.YeniParolaEpostasiYolla(calisan.Eposta, calisan.Parola);
                return calisan.No;
            }
            else
            {
                return 0;
            }
        }
        
        public static int KullaniciGirisiniDogrula(string ePosta, string parola)
        {
            int sonuc = 0;//sonuc degeri
            //servis çağrılıyor ve veri erişim katmanından çalışan numarası alınıyor.
            sonuc = VEK.Calisan.KullaniciGirisiniDogrula(ePosta, parola);
            return sonuc;    
        }
        public static SISVarliklar.Calisan CalisanGetir(int calisanNo)
        {
            VAR.Calisan calisan = null;
            calisan = VEK.Calisan.CalisanGetir(calisanNo);
            return calisan;
        }
    } 
}
