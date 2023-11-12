﻿using System;
using System.Collections.Generic;

namespace TrafikCezaSistemi
{
    public class CezaBilgisi
    {
        public string Plaka { get; set; }
        public string CezaTuru { get; set; }
        public decimal CezaMiktari { get; set; }
        public DateTime CezaGirisTarihi { get; set; }
        public DateTime CezaSonOdemeTarihi { get; set; }

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
            // Use the constructor with parameters when creating instances
            return new List<CezaBilgisi>
            {
                new CezaBilgisi("34 ABC 123", "Hız Sınırı İhlali", 200.0m, DateTime.Now, DateTime.Now.AddMonths(1)),
                new CezaBilgisi("06 XYZ 789", "Park Yasağı", 100.0m, DateTime.Now.AddDays(-15), DateTime.Now.AddMonths(2)),
            };
        }
    }
}
