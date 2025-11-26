using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE201_225060005
{
    class Film
    {
        // uye degiskenleri
        private string ad;
        private double puan;
        private string yonetmen;
        private int sure; // dakika cinsinden 

        // puana erisim kontrolu
        public double Puan
        {
            get { return puan; }
            set
            {
                if (value >= 0.0 && value <= 10.0)
                {
                    puan = value;
                }
                else
                {
                    // eger puan 10 dan buyuk olursa puan olarak 10 atar
                    Console.WriteLine("Uyarı: Puan 0.0 ile 10.0 arasında olmalıdır. Maksimum değer atandı.");
                    puan = (value > 10.0) ? 10.0 : 0.0;
                }
            }
        }

        // set ve get methodlari 
        public string Ad { get { return ad; } set { ad = value; } } 
        public string Yonetmen { get { return yonetmen; } set { yonetmen = value; } } 
        public int Sure { get { return sure; } set { sure = value; } } 

        public string Tur { get; set; }
        public int Yil { get; set; }
        public string Dil { get; set; }

        // Boş constructor
        public Film()
        {
            Ad = "Bilinmeyen";
            Puan = 0.0;
            Yonetmen = "Bilinmeyen";
            Sure = 0;
            Tur = "Bilinmiyor";
            Yil = 0;
            Dil = "Bilinmiyor";
        }

        // Parametreli constructor
        public Film(string ad, double puan, string yonetmen, int sure, string tur, int yil, string dil)
        {
            Ad = ad;
            Puan = puan; 
            Yonetmen = yonetmen;
            Sure = sure;
            Tur = tur;
            Yil = yil;
            Dil = dil;
        }

        // Member function 1: Puan Arttirir 
        public void PuanArtir(double miktar)
        {
            Puan += miktar;
        }

        // Member function 2: Süre Artır 
        public void SureArttir(int ekSure)
        {
            Sure += ekSure;
        }

        // Member function 3: Süreyi Saat:Dakika formatinda döndürür 
        public string SuresiSaatDakika()
        {
            if (Sure <= 0) return "Süre Belirtilmemiş";

            int saat = Sure / 60;
            int dakika = Sure % 60;

            return $"{saat} saat {dakika} dakika";
        }

        // ToString override
        public override string ToString()
        {
            return $"Film: {Ad}, Puan: {Puan}/10, Yönetmen: {Yonetmen}, Süre: {Sure} dk ({SuresiSaatDakika()}), Tür: {Tur}, Yıl: {Yil}, Dil: {Dil}";
        }
    }
}

