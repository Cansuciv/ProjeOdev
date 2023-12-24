using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TrafikCezaSistemi
{
    public class CezaBilgisi : Ceza
    {

        public CezaBilgisi(string plaka, string cezaTuru, decimal cezaMiktari, DateTime cezaGirisTarihi, DateTime cezaSonOdemeTarihi)
        {
            this.Plaka = plaka;
            this.CezaTuru = cezaTuru;
            this.CezaMiktari = cezaMiktari;
            this.CezaGirisTarihi = cezaGirisTarihi;
            this.CezaSonOdemeTarihi = cezaSonOdemeTarihi;
        }

        public static List<CezaBilgisi> CezaListesiOlustur()
        {
            return new List<CezaBilgisi>
            {
                new CezaBilgisi("34 ABC 123", "Hız Sınırı İhlali", 200.0m, DateTime.Now, DateTime.Now.AddMonths(1)),
                new CezaBilgisi("06 XYZ 789", "Park Yasağı", 100.0m, DateTime.Now.AddDays(-15), DateTime.Now.AddMonths(2)),
            };

        }

        public override string AnaBilgiMesaji()
        {
            return "Ceza Bilgileri.\n";
        }
    }
}

