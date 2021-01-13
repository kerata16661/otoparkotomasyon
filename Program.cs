using System;
using System.Collections.Generic;
using ConsoleTables;

namespace OtoparkOtomasyon {
    class Program {
        private static int KullaniciGirisAlma () {
            int sonuc = 0;
            bool ciktiMi = false;
            while (!ciktiMi) {
                if (int.TryParse (console.ReadLine (), out sonuc)) {
                    ciktiMi = true;
                } else {
                    console.WriteLine ("Yanlıs Yazdınız");
                    console.WriteLine ("Bir Daha Yazınız");
                }
            }
            return sonuc;
        }
        private static void Baslatma (ParkYeri parkYeri) {
            console.WriteLine ("Kac tane motorsikletler icin yer olacagını girin");
            int sayiMotorsiklerYeri = KullaniciGirisAlma ();
            for (int i = 0; i < sayiMotorsiklerYeri; i++) {
                parkYeri.ParkYeriEkleme (new ParkYeri (AracTuru.IkiTekerlekli));
            }
            console.WriteLine ("Kac tane arabalar icin yer olacagını girin");
            int sayiArabaYeri = KullaniciGirisAlma ();
            for (int i = 0; i < sayiArabaYeri; i++) {
                parkYeri.ParkYeriEkleme (new ParkYeri (AracTuru.DortTekerlekli));
            }
            console.WriteLine ("Kac tane kamyon icin yer olacagını girin");
            int sayiKamyonYeri = KullaniciGirisAlma ();
            for (int i = 0; i < sayiKamyonYeri; i++) {
                parkYeri.ParkYeriEkleme (new ParkYeri (AracTuru.TicariArac));
            }
        }
        private static void DolulukAyrintilariniGoruntule (ParkYeri parkYeri) {
            if (parkYeri.ParkBileti.Count == 0) {
                console.WriteLine ("Park eden arac yok...");
            } else {
                var tablo = new ConsoleTables ("Yer Numarasi", "Arac Numarasi", "Giris Zamani", "Cikis Zamani");
                foreach (var parkBileti in parkYeri.parkBiletleri) {
                    if (!parkBileti.SuresiDolduMu) {
                        table.AddRow (parkBileti.yerNumarasi, parkBileti.AracNumarasi, parkBileti.AracTuru.ToString (), parkBileti.GirisZamani, parkBileti.CikisZamani);
                    }
                }
                tablo.Write ();
            }
            console.WriteLine ("herhangi bir tusa basiniz");
            Console.ReadKey ();
        }
        private static void ParkEdenArac (AracTuru aracTuru, ParkYeri parkYeri) {
            ParkYeri parkYeri = parkYeri.BosYerDurumu (aracTuru);
            if (parkYeri != null) {
                Arac arac = AracGetir (aracTuru);
                console.WriteLine ("Arac sayisi giriniz")
                int aracNumarasi = KullaniciGirisAlma ();
                if (!parkYeri.AracNumarasiVeBiletVarMı(aracNumarasi)) {
                    arac.AracNumarasi = aracNumarasi;
                    parkYeri.ParkEdenArac (arac);
                    console.WriteLine ("Park yeriniz kapilmis");
                } else {
                    console.WriteLine ("arac numarasi zaten mevcut");
                }
            } else {
                console.WriteLine ("Uzgunuz, size uygun park yeri kalmamis");
            }
            console.WriteLine ("Herhangi bir tusa basiniz");
            console.ReadKey ();
        }
        private static void ParkMenusunuGoruntule (ParkYeri parkYeri) {
            Console.WriteLine ("1. İki Tekerlekliler icin");
            Console.WriteLine ("2. Dort Tekerlekliler icin");
            Console.WriteLine ("3. Ticari Araclar icin");
            int secim = KullaniciGirisAlma ();
            switch (secim) {
                case 1:
                    ParkEdenArac (AracTuru.IkiTekerlekli, parkYeri);
                    break;
                case 1:
                    ParkEdenArac (AracTuru.DortTekerlekli, parkYeri);
                    break;
                case 1:
                    ParkEdenArac (AracTuru.TicariArac, parkYeri);
                    break;
                default:
                    console.WriteLine ("Yanlıs numara girdiniz");
                    break;
            }
        }
        static void Main (string[] args) {
            ParkYeri parkYeri = new ParkYeri ();
            Intialize (parkYeri);

            bool ciktiMi = false;
            while (!ciktiMi) {
                console.WriteLine ("1. otopark mevcut doluluk ayrintilari");
                console.WriteLine ("2. park eden araclar");
                console.WriteLine ("3. Ayrılan araclar");
                console.WriteLine ("0. Geri");
                console.WriteLine ("Lutfen bir secenek seciniz");
                int menuSecenekleri = KullaniciGirisAlma ();
                switch (menuSecenekleri) {
                    case 1:
                        DolulukAyrintilariniGoruntule (parkYeri);
                        break;
                    case 2:
                        ParkMenusunuGoruntule (parkYeri;
                            break;
                            case 3:
                                console.WriteLine ("lutfen arac sayisi giriniz"); int aracNumarasi = KullaniciGirisAlma ();
                                if (parkYeri.AracNumarasiAyrilma (aracNumarasi)) {
                                    ParkYeri parkYeri = parkYeri.ParkEdenAracNumarasi (aracNumarasi);
                                    parkYeri.AyrilanArac ();
                                    parkYeri.BiletDuzenleme (parkYeri.parkBileti);
                                    Console.WriteLine ("Arac basariyla ayrildi");
                                    console.ReadKey ();
                                }
                                break;

                            case 0:
                                ciktiMi = true;
                                break;

                            default:
                                console.WriteLine ("yanlis tuslama yaptiniz");
                                break;
                        }
                }
            }
        }
    }