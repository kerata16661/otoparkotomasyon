﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class Arabalar : Arac {
        public Araba () {
            Turu = AracTuru.DortTekerlekli ();
        }
    }
}