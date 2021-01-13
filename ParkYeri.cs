using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class ParkYeri {
        public ParkBileti ParkBileti { get; set; }
        public bool yerDurumu { get; set; }
        public Arac Arac { get; set; }
        public AracTuru AracTuru { get; set; }
        public int YerNumarasi { get; set; }
        static int count = 0;

        public ParkYeri (AracTuru aracTuru) {
            yerDurumu = true;
            this.AracTuru = aracTuru;
            YerNumarasi = count++;
        }

        public void YerDurumuDegisiklik (bool durum) {
            yerDurumu = durum;
        }

        public void AyrilanArac () {
            Arac = null;
            yerDurumu (true);
            ParkBileti.BitiSDurumuDegistir (true);
        }
    }
}