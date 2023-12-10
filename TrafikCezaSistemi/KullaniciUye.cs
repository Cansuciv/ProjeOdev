using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class KullaniciUye : KullaniciGiris
    {
        public string? kullaniciTelefonNo;

        //public override string kullaniciTelefonNo()
        //{
        //    throw new NotImplementedException();
        //}

        //public KullaniciUye(string kullaniciAdi, string sifre, string kullaniciTelefonNo) : base(kullaniciAdi, sifre)
        //{
        //    //if (GecerliTelefonNo(kullaniciTelefonNo))
        //    //{
        //    //    KullaniciTelefonNo = kullaniciTelefonNo;
        //    //}
        //    //else
        //    //{
        //    //    throw new ArgumentException("Telefon numarası 10 rakamdan oluşmalıdır.");
        //    //}
        //}

        

        //public string KullaniciTelefonNo
        //{
        //    get { return kullaniciTelefonNo; }
        //    set
        //    {
        //        if (GecerliTelefonNo(value))
        //        {
        //            kullaniciTelefonNo = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("Telefon numarası 10 rakamdan oluşmalıdır.");
        //        }
        //    }
        //}

        //private static bool GecerliTelefonNo(string telefonNo)
        //{
        //    string telefonNoStr = telefonNo;
        //    //return telefonNoStr.Length == 10;
        //}
    }
}
