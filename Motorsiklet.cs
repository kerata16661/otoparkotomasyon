using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class Motorsiklet : Arac {
        public Motorsiklet () {
            Turu = AracTuru.IkiTekerlekli ();
        }
    }
}