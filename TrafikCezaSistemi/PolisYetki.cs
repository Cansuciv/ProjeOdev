using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public class PolisYetki:CezaBilgisi
    {
        public PolisYetki(string plaka, string cezaTuru, decimal cezaMiktari, DateTime cezaGirisTarihi, DateTime cezaSonOdemeTarihi)
        : base(plaka, cezaTuru, cezaMiktari, cezaGirisTarihi, cezaSonOdemeTarihi)
        {
        }

        public override string AnaBilgiMesaji()
        {
            return "Ceza Bilgileri";
        }
    }
}
