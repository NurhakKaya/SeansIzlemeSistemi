using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SISVeriErisimKatmani
{
    public class Baglanti
    {
        static string baglantiMetni = "Server=.;Database=SIS(SeansIzlemeSistemi);Integrated Security=SSPI";
        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            return baglanti;
        }
        public static void BaglantiSonlandir(SqlConnection baglanti)
        {
            if (baglanti==null)
            {
                return;
            }
            if (baglanti.State!=ConnectionState.Closed&&baglanti.State!=ConnectionState.Broken)
            {
                baglanti.Close();
            }
            baglanti.Dispose();
        }
    }
}
