using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISVarliklar
{
    public class Seans
    {
        #region Local Variables
        private int no;
        private int uzmanNo;
        private int hastaNo;
        private DateTime tarih;
        private string baslangicSaati = string.Empty;
        private string bitisSaati = string.Empty;
        private string seansNotu = string.Empty;
        private int iptalEdenNo;
        private string iptalNotu = string.Empty;
        private string goruntuMetni = string.Empty;
        private string hastaBilgisi = string.Empty;
        private string uzmanBilgisi = string.Empty;
        private bool seansYapildi = false;
        private bool hastaIptalEtti = true;
        #endregion

        #region Public Properties
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public int UzmanNo
        {
            get { return uzmanNo; }
            set { uzmanNo = value; }
        }
        public int HastaNo
        {
            get { return hastaNo; }
            set { hastaNo = value; }
        }
        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public string BaslangicSaati
        {
            get { return baslangicSaati; }
            set { baslangicSaati = value; }
        }
        public string BitisSaati
        {
            get { return bitisSaati; }
            set { bitisSaati = value; }
        }
        public string SeansNotu
        {
            get { return seansNotu; }
            set { seansNotu = value; }
        }
        public int IptalEdenNo
        {
            get { return iptalEdenNo; }
            set { iptalEdenNo = value; }
        }
        public string IptalNotu
        {
            get { return iptalNotu; }
            set { iptalNotu = value; }
        }
        public string HastaBilgisi
        {
            get { return hastaBilgisi; }
            set { hastaBilgisi = value; }
        }
        public string UzmanBilgisi
        {
            get { return uzmanBilgisi; }
            set { uzmanBilgisi = value; }
        }
        public bool SeansYapildi
        {
            get { return seansYapildi; }
            set { seansYapildi = value; }
        }
        public bool HastaIptalEtti
        {
            get { return hastaIptalEtti; }
            set { hastaIptalEtti = value; }
        }
        public string GoruntuMetni
        {
            get
            {
                string metin = string.Format("{0} / {1} - {2}", tarih.ToShortDateString(), baslangicSaati, bitisSaati);
                if (!string.IsNullOrEmpty(hastaBilgisi))
                {
                    metin += "(" + hastaBilgisi + ")";
                }
                if (IptalEdenNo > 0)
                {
                    metin += "[ipt]";
                }
                return metin;
            }
        }
        #endregion
    }
}
