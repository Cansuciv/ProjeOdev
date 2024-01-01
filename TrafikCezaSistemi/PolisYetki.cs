using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class PolisYetki:CezaBilgisi
    {
        #region Methods
        public PolisYetki(string plaka, string cezaTuru, decimal cezaMiktari, DateTime cezaGirisTarihi, DateTime cezaSonOdemeTarihi)
        : base(plaka, cezaTuru, cezaMiktari, cezaGirisTarihi, cezaSonOdemeTarihi)
        {
        }

        public override string AnaBilgiMesaji()
        {
            #region Mesaj
            return "Ceza Bilgileri Yetkili Polis Tarafından Görüntüleniyor.";
            #endregion
        }
        #endregion
    }
}
