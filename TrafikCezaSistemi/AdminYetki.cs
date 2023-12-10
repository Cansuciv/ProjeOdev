using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TrafikCezaSistemi
{
    public class AdminYetki :CezaBilgisi
    {
        public AdminYetki(string plaka, string cezaTuru, decimal cezaMiktari, DateTime cezaGirisTarihi, DateTime cezaSonOdemeTarihi)
        : base(plaka, cezaTuru, cezaMiktari, cezaGirisTarihi, cezaSonOdemeTarihi)
        {
        }

        public string? yeniCezaTuru { get; set; }
        public decimal yeniCezaMiktari { get; set; }
        public DateTime yeniCezaGirisTarihi { get; set; }
        public DateTime yeniCezaSonOdemeTarihi { get; set; }       
    }
}
