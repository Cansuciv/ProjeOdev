using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class KullaniciYetki:CezaBilgisi , IOdemeBilgileri
    {
        #region Methods
        public KullaniciYetki(string plaka, string cezaTuru, decimal cezaMiktari, DateTime cezaGirisTarihi, DateTime cezaSonOdemeTarihi)
        : base(plaka, cezaTuru, cezaMiktari, cezaGirisTarihi, cezaSonOdemeTarihi)
        {
        }
        public string OdemeMesaj()
        {
            #region Mesaj
            return "Ödeme yapmak için kart bildilerinizi giriniz.";
            #endregion
        }
        #endregion

        #region Properties
        public int KartNumarası { get; set; }
        public int Skt { get; set; }
        public int cvv { get; set; }
        public float Tutar { get; set; }
        #endregion
    }
}
