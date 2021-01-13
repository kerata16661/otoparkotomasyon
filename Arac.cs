using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class Arac {
        public int AracNumarasi { get; set; }
        public AracTuru Turu { get; set; }
    }
    public enum AracTuru {
        IkiTekerlekli,
        DortTekeklekli,
        TicariArac
    }
}