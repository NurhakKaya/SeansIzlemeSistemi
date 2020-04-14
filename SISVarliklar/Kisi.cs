using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISVarliklar
{
    public class Kisi
    {
        #region LocalVariables
        protected int no;
        protected string tcKimlikNo = String.Empty;
        protected string ad = String.Empty;
        protected string soyad = String.Empty;
        protected string eposta = String.Empty;
        protected string cepTel = String.Empty;
        protected string evTel = String.Empty;
        #endregion

        #region Public Properties
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public string TCKimlikNo
        {
            get { return tcKimlikNo; }
            set { tcKimlikNo = value.Trim(); }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }
        public string CepTel
        {
            get { return cepTel; }
            set { cepTel = value; }
        }
        public string EvTel
        {
            get { return evTel; }
            set { evTel = value; }
        }
        public virtual string GoruntuMetni
        {
            get
            {
                return string.Format("{0} {1}", ad, soyad);
            }
        } 
        #endregion
    }
}
