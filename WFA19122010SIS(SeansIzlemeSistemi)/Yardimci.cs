using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WFA19122010SIS_SeansIzlemeSistemi_
{
    public class Yardimci
    {
        public static int KullaniciNo = 0;
        public static void HataKaydet(Exception ex)
        {
            //Hata isletim sisteminin olay gunlugune yaziliyor.
            string dosyaAdi=Environment.CurrentDirectory+"\\WFA19122010SIS_SeansIzlemeSistemi_Hata_"+Guid.NewGuid()+".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }
    }
}
