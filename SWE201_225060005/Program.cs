using System;

namespace SWE201_225060005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boş constructor ile nesne oluştur ve sonra değer ata
            Film film1 = new Film();
            film1.Ad = "Yüzüklerin Efendisi";
            film1.Yil = 2001;
            film1.Puan = 9.2; 
            film1.Tur = "Fantastik";

            // Parametreli constructor ile nesne oluştur
            Film film2 = new Film("Inception", 8.8, "Christopher Nolan", 148, "Bilim Kurgu", 2010, "İngilizce");
            Film film3 = new Film("Whiplash", 8.5, "Damien Chazelle", 106, "Dram", 2014, "İngilizce");

            // 10 dan buyuk puan denemesi 
            Film film4 = new Film("Limit Üstü", 12.0, "Bir Yönetmen", 90, "Deneysel", 2024, "Türkçe"); // Uyarıyı görelim!

            // film listesi 
            List<Film> filmler = new List<Film> { film1, film2, film3, film4 };

            Console.WriteLine("--- Film Listesi ---");
            foreach (var f in filmler)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n--- Inception Filmi Üzerinde İşlemler ---");

            // Puan artırma islemi 
            film2.PuanArtir(0.5);
            Console.WriteLine($"Puan Artırıldı (0.5): {film2.Puan}");

            // Süre artırma islemi 
            film2.SureArttir(15);
            Console.WriteLine($"Süre Artırıldı (15 dk): {film2.SuresiSaatDakika()}");

            // Yönetmen değiştirme ozelligi 
            film2.Yonetmen = "Michael Bay";
            Console.WriteLine($"Yönetmen Değiştirildi: {film2.Yonetmen}");

            Console.WriteLine($"\nInception Güncel Durum:\n{film2}");

            // ===  Listeyi Filtreleme Örneği puani 9 dan fazla olan filmler  ===
            Console.WriteLine("\n--- Puanı 9.0 ve Üzeri Filmler  ---");

            var yuksekPuanliFilmler = filmler.Where(f => f.Puan >= 9.0).ToList();

            if (yuksekPuanliFilmler.Count > 0)
            {
                foreach (var f in yuksekPuanliFilmler)
                {
                    Console.WriteLine($"- {f.Ad} ({f.Yil}), Puan: {f.Puan}");
                }
            }
            else
            {
                Console.WriteLine("9.0 ve üzeri puana sahip film bulunamadi.");
            }

            Console.WriteLine("\nProgram Sonlandi.");
            Console.ReadLine();
        }
    }
}