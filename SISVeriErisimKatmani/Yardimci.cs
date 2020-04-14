using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SISVeriErisimKatmani
{
    public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            //Hata isletim sisteminin olay gunlugune yaziliyor.
            string dosyaAdi = Environment.CurrentDirectory + "\\SISWin_Hata_" + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi,ex.ToString());
        }
    }
}
