using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class YetkiliPolisGirişi
    {
        public string YPKullaniciAdi { get; set; }
        public string YPSifre { get; set; }


        public YetkiliPolisGirişi(string YpKullaniciAdi, string YpSifre) 
        {
            YPKullaniciAdi = (YpKullaniciAdi=="yetkili1" || YpKullaniciAdi == "yetkili2" || YpKullaniciAdi == "yetkili3") ? YpKullaniciAdi : "yetkili1";
            YPSifre= (YpSifre=="yetkili1" || YpSifre == "yetkili2" || YpSifre == "yetkili3") ? YpSifre :"yetkili1";
        }

        public bool YetkiliGirisKontrol(string YpKullaniciAdi, string YpSifre)
        {
            return (YpKullaniciAdi == "yetkili1" && YpSifre == "yetkili1") || 
                   (YpKullaniciAdi == "yetkili2" && YpSifre == "yetkili2") || 
                   (YpKullaniciAdi == "yetkili3" && YpSifre == "yetkili3");
        }

    }
}
