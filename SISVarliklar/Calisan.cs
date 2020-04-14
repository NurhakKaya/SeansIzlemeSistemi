using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISVarliklar
{
    public class Calisan:Kisi
    {
        #region Local Variables
        private string unvan = String.Empty;
        private string parola = String.Empty;
        private CalisanTipleri calisanTipi; 
        #endregion

        public enum CalisanTipleri
        {
            SistemYoneticisi,
            Sekreter,
            Uzman
        }
        #region Public Properties
        public string Unvan 
        {
            get { return unvan; }
            set { unvan = value; }
        }
        public string Parola 
        {
            get { return parola; }
            set { parola = value; }
        }
       
        public CalisanTipleri CalisanTipi 
        {
            get { return calisanTipi; }
            set { calisanTipi = value; }
        }
        public override string GoruntuMetni
        {
            get
            {
                if (calisanTipi == CalisanTipleri.Uzman)
                {
                    return string.Format("{0} {1} ({2})", base.ad, base.soyad, unvan);
                }
                else
                {
                    return base.GoruntuMetni;
                }
            }
        }
        #endregion
    }
}
