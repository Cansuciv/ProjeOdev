using System;
using System.Collections.Generic;

namespace TrafikCezaSistemi
{
    public class CezaBilgisi:Ceza
    {
        public CezaBilgisi(string Plaka, string CezaTuru, decimal CezaMiktari, DateTime CezaGirisTarihi, DateTime CezaSonOdemeTarihi)
        {
        }

        public override List<Ceza> CezaListesiOlustur()
        {

            return new List<Ceza> 
            {
                new CezaBilgisi("34 ABC 123", "Hız Sınırı İhlali", 200.0m, DateTime.Now, DateTime.Now.AddMonths(1)),
                new CezaBilgisi("06 XYZ 789", "Park Yasağı", 100.0m, DateTime.Now.AddDays(-15), DateTime.Now.AddMonths(2)),
            };
        }
    }
}

