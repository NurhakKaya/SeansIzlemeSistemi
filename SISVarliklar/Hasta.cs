using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISVarliklar
{
    public class Hasta : Kisi
    {
        #region Local Variables
        private DateTime dogumTarihi = DateTime.MinValue;
        private string cinsiyeti = String.Empty;
        private string adres = String.Empty;
        #endregion

        #region Public Properties
        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }
        public string Cinsiyeti
        {
            get { return cinsiyeti; }
            set { cinsiyeti = value; }
        }
        public string Adres 
        {
            get { return adres; }
            set { adres = value; }
        }
        #endregion

        public override string GoruntuMetni
        {
            get
            {
                return string.Format("{0} {1} {2}", ad, soyad, evTel);
            }
        }
    }
}
