using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class KullaniciUye : KullaniciGiris
    {
        private int kullaniciTelefonNo;

        public KullaniciUye(string kullaniciAdi, string sifre, int kullaniciTelefonNo) : base(kullaniciAdi, sifre)
        {
            if (GecerliTelefonNo(kullaniciTelefonNo))
            {
                KullaniciTelefonNo = kullaniciTelefonNo;
            }
            else
            {
                throw new ArgumentException("Telefon numarası 10 rakamdan oluşmalıdır.");
            }
        }

        public int KullaniciTelefonNo
        {
            get { return kullaniciTelefonNo; }
            set
            {
                if (GecerliTelefonNo(value))
                {
                    kullaniciTelefonNo = value;
                }
                else
                {
                    throw new ArgumentException("Telefon numarası 10 rakamdan oluşmalıdır.");
                }
            }
        }

        private bool GecerliTelefonNo(int telefonNo)
        {
            string telefonNoStr = telefonNo.ToString();
            return telefonNoStr.Length == 10;
        }
    }
}
