using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class AdminGiris
    {
        #region Properties
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        #endregion

        #region Methods
        public AdminGiris(string kullaniciAdi, string sifre)
        {
            #region Admin Giriş Bilgileri
            KullaniciAdi = (kullaniciAdi == "admin1" || kullaniciAdi == "admin2") ? kullaniciAdi : "admin1";
            Sifre = (sifre == "admin123" || sifre == "admin321") ? sifre : "admin123";
            #endregion
        }

        public bool KontrolGiris(string kullaniciAdi, string sifre) 
        {
            #region Admin Giriş Kontrol
            return (kullaniciAdi == "admin1" && sifre == "admin123") || (kullaniciAdi == "admin2" && sifre == "admin321");
            #endregion
        }
        #endregion
    }
}
