using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaSistemi
{
    public interface IOdemeBilgileri
    {
        #region Properties
        int KartNumarası { get; set; }
        int Skt { get; set; }
        int cvv { get; set; }
        float Tutar { get; set; }
        #endregion

        #region Methods
        string OdemeMesaj();
        #endregion
    }
}
