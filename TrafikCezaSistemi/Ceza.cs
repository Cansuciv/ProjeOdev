using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public abstract class Ceza
    {

        public string? Plaka { get; set; }
        public string? CezaTuru { get; set; }
        public decimal CezaMiktari { get; set; }
        public DateTime CezaGirisTarihi { get; set; }
        public DateTime CezaSonOdemeTarihi { get; set; }
        public abstract List<Ceza> CezaListesiOlustur();

    }
}
