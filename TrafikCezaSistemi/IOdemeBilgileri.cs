using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public interface IOdemeBilgileri
    {
        int KartNumarası { get; set; }
        int Skt { get; set; }
        int cvv { get; set; }
        float Tutar { get; set; }
        string OdemeMesaj();

    }
}
