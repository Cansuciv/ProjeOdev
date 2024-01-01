using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public abstract class Ceza
    {
        #region Properties
        public string? Plaka { get; set; }
        public string? CezaTuru { get; set; }
        public decimal CezaMiktari { get; set; }
        public DateTime CezaGirisTarihi { get; set; }
        public DateTime CezaSonOdemeTarihi { get; set; }
        #endregion

        #region Methods
        public abstract string AnaBilgiMesaji();
        #endregion
    }
}
