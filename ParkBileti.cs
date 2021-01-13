using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class ParkBileti {
        public int AracNumarasi { get; set; }
        public int YerNumarasi { get; set; }
        public DateTime GirisZamani { get; set; }
        public DateTime CikisZamani { get; set; }
        public AracTuru AracTuru { get; set; }
        public bool AyrildiMi { get; set; }

        public ParkBileti () {
            GirisZamani = DateTime.Now;
            CikisZamani = GirisZamani.Add (new TimeSpan (0, 30, 0));
            AyrildiMi = false;
        }

        public void BitiSDurumuDegistir (bool durum) {
            AyrildiMi = durum;
        }
    }
}