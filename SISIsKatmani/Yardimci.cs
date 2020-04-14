using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace SISIsKatmani
{
    public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            //Hata isletim sisteminin olay gunlugune yaziliyor.
            string dosyaAdi=Environment.CurrentDirectory+"\\SISIsKatmani_Hata_"+Guid.NewGuid()+".txt";
            File.WriteAllText(dosyaAdi,ex.ToString());
        }
        public static void YeniParolaEpostasiYolla(string eposta, string parola)
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = "mail.hesapadi.com";
            NetworkCredential crd = new NetworkCredential("hesap", "parola");
            sc.Credentials = crd;
            MailMessage msj = new MailMessage();
            msj.From = new MailAddress("gonderen@hesapadi.com");
            msj.To.Add(eposta);
            msj.Subject = "Parola değişikliği...";
            msj.Body = "Yeni parolanız: " + parola;
            try
            {
                sc.Send(msj);
            }
            catch (Exception ex)
            {
                HataKaydet(ex);
            }

        }
        public static string ParolaOlustur()
        {
            //Random r=new Random();
            //return r.Next(100, 999).ToString());
            return "123";
        }
    }
}
