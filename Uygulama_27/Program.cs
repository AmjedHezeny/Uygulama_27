using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Metodlar> ogrenciler = new List<Metodlar>()
            {
                new Metodlar() {isim="Ahmet", soyisim="Kaçar", yas=19, ortalama=3.1},
                new Metodlar() {isim="Ayşe", soyisim="Sarı", yas=18, ortalama=3.5},
                new Metodlar() {isim="Mehmet", soyisim="Yılmaz", yas=19, ortalama=2.1},
                new Metodlar() {isim="Halil", soyisim="Sönmez", yas=20, ortalama=2.5},
                new Metodlar() {isim="Fatma", soyisim="Sönmez", yas=22, ortalama=3.0},
                new Metodlar() {isim="Elif", soyisim="Taşçı", yas=21, ortalama=3.4},
                new Metodlar() {isim="Elif", soyisim="Bilgin", yas=20, ortalama=2.2},
                new Metodlar() {isim="Elif", soyisim="Çetiner", yas=19, ortalama=2},
                new Metodlar() {isim="Ahmet", soyisim="Kaçar", yas=21, ortalama=2.7},
                new Metodlar() {isim="Hakan", soyisim="Uysal", yas=22, ortalama=3.4},
                new Metodlar() {isim="Leyla", soyisim="Kabakçı", yas=21, ortalama=3.7}
            };

            Console.WriteLine("*****************************************************");
            var ogrenci = ogrenciler.Where(o => o.yas > 20);
            Console.WriteLine("20 Yaşından Büyük Öğrenciler:");
            Console.WriteLine("------------------------------");

            foreach (var ogr in ogrenci)
            {
                Console.WriteLine(ogr.isim + " " + ogr.soyisim);
            }
            Console.WriteLine("*****************************************************");
            Console.WriteLine();


            Console.WriteLine("*****************************************************");
            var siralaMetodlar = ogrenciler.OrderBy(o => o.isim);
            Console.WriteLine("İsimlerine Göre Alfabetik Sıralama:");
            Console.WriteLine("------------------------------------");

            foreach (var ogr in siralaMetodlar)
            {
                Console.WriteLine(ogr.isim + " " + ogr.soyisim + " " + ogr.ortalama);
            }
            Console.WriteLine("*****************************************************");
            Console.WriteLine();



            Console.WriteLine("*****************************************************");
            var ortMetodlar = ogrenciler.Where(ogr => ogr.ortalama >= ogrenciler.Average(s => s.ortalama));
            Console.WriteLine("Sınıf Ortalaması : " + Math.Round(ogrenciler.Average(s => s.ortalama), 2));
            Console.WriteLine("Ortalamanın Üstünde Not Ortalamasına Sahip Öğrenciler:");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var ogr in ortMetodlar)
            {
                Console.WriteLine(ogr.isim + " " + ogr.soyisim + " " + ogr.ortalama);
            }
            Console.WriteLine("*****************************************************");

            Console.ReadKey();
        }
    }
}
