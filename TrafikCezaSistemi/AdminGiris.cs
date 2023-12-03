using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class AdminGiris
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public AdminGiris(string kullaniciAdi, string sifre)
        {
            KullaniciAdi = (kullaniciAdi == "admin1" || kullaniciAdi == "admin2") ? kullaniciAdi : "admin1";
            Sifre = (sifre == "admin123" || sifre == "admin321") ? sifre : "admin123";
        }

        public bool KontrolGiris(string kullaniciAdi, string sifre) 
        {
            return (kullaniciAdi == "admin1" && sifre == "admin123") || (kullaniciAdi == "admin2" && sifre == "admin321");
        }

    }
}
