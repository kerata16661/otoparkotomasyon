using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu {
    class Otopark {
        public List<ParkYeri> ParkYerleri { get; set; }
        public List<ParkBileti> ParkBiletleri { get; set; }

        public Otopark () {
            ParkYerleri = new List<ParkYeri> ();
            ParkBiletleri = new List<ParkBileti> ();
        }

        public bool AracNumarasiVarMi (int aracNumarasi) {
            return ParkYerleri.Exists (yer => yer.ParkBileti != null && yer.ParkBileti.aracNumarasi == aracNumarasi);
        }

        public bool AracNumarasiVeBiletVarMı(int aracNumarasi) {
            return ParkYerleri.Exists (yer =>
                yer.ParkBileti != null && yer.ParkBileti.aracNumarasi == aracNumarasi && !yer.ParkBileti.SuresiDolduMu);
        }

        public ParkYeri BosYerDurumu (AracTuru aracTuru) {
            return ParkYerleri.FirstOrDefault (yer => yer.BosMu == true && yer.AracTuru == aracTuru);
        }

        public ParkYeri AracNumarasindanParkYeriAlma (int aracNumarasi) {
            return ParkYerleri.Find (yer => yer.ParkBileti != null && yer.ParkBileti.AracNumarasi == aracNumarasi);
        }

        public ParkBileti BiletDuzenleme (int aracNumarasi, AracTuru, aracTuru, int yerNumarasi) {
            ParkBileti parkBileti = new parkBileti { AracNumarasi = aracNumarasi, AracTuru = aracTuru, YerNumarasi = yerNumarasi };
            ParkBiletleri.Add (parkBileti);
            return parkBileti;
        }

        public void ParkEdenArac (Arac = arac) {
            ParkYeri parkYeri = BosYerDurumu (arac.Turu);
            int yerNumarasi = parkYeri.AracParkEtme (arac);
            parkYeri.ParkBileti = BiletDuzenleme (arac.AracNumarasi, arac.Turu, yerNumarasi);
        }

        public void BiletDegisiklikDurumu (ParkBileti parkBileti) {
            ParkBiletleri.Find (bilet => bilet.Equals (parkBileti)).ChangeExpiryStatus (true);
        }

        public void ParkYeriEkleme (ParkYeri, parkYeri) {
            ParkYerleri.Add (parkyeri)
        }
    }
}