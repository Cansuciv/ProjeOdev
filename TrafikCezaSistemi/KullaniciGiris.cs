using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class KullaniciGiris
    {
        public string KKullaniciAdi { get; set; }
        public string KSifre {  get; set; }


        public KullaniciGiris(string kKullaniciAdi, string kSifre) 
        {
            KKullaniciAdi = (kKullaniciAdi == "kullanıcı1" || kKullaniciAdi == "kullanıcı2" || kKullaniciAdi == "kullanıcı3") ? kKullaniciAdi : "kullanıcı1";
            KSifre = (KSifre == "kullanıcı1" || KSifre == "kullanıcı2" || KSifre == "kullanıcı3") ? kSifre : "kullanıcı1";
        } 

        public bool KullaniciGirisKontrol(string kKullaniciAdi, string kSifre)
        {
            return (kKullaniciAdi == "kullanıcı1" && kSifre == "kullanıcı1") ||
                   (kKullaniciAdi == "kullanıcı2" && kSifre == "kullanıcı2") ||
                   (kKullaniciAdi == "kullanıcı3" && kSifre == "kullanıcı3");

        }

    }
}
