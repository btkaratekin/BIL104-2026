using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
       static List<Kitap> Kitaplar = KitapListe.ListeyiGetir();
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Clear();
                Console.WriteLine("LINQ İşlemleri Select() ve Where() Metodu Kullanımı");
                Console.WriteLine("\n\nMenü");
                Console.WriteLine("1. Tüm Kitapları Listele");
                Console.WriteLine("2. Sadece Kitap Adı Yazarı ve Sayfa Sayısını göre Listele");
                Console.WriteLine("3. Seçilen Kategoriye Göre Kitapları ve Yazarları Listele");
                Console.WriteLine("4. Fiyat Aralığına Göre Kitapları Listele");
                Console.WriteLine("5. İçerisinde Geçen Kelimeye Göre Kitapları Listele");
                Console.WriteLine("6. Çıkış");
                Console.Write("\nSeçiminiz....:");
                int secim =int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            TumKitaplariListele();
                            break;
                        }
                    case 2:
                        {
                            KitapAdiYazariSayfaSayisiListele();
                            break;
                        }
                    case 3:
                        {
                            KategoriyeGoreListele();
                            break;
                        }
                    case 4:
                        {
                            FiyatAraliginaGoreListele();
                            break;
                        }
                    case 5:
                        {
                            KelimeyeGoreListele();
                            break;
                        }
                    case 6:
                        {
                         Console.WriteLine("Çıkış yapılıyor...");
                         Thread.Sleep(2000);
                         return;
                        }

                    default:
                        { Console.WriteLine("Geçersiz Seçim...Tekrar Deneyin...");
                            Thread.Sleep(2000);
                        }
                        break;
                }


            }
        }

        private static void KelimeyeGoreListele()
        {
            Console.Clear();
            Console.Write("Kitaplar İçerisinde Geçen Kelime....:");
            string kelime = Console.ReadLine();
            var Liste = Kitaplar.Where(p => p.Adi.ToUpper().Contains(kelime.ToUpper())).ToList();
            Console.WriteLine($"\nKitap Adında '{kelime}' Kelimesi Geçen Kitaplar\n");
            foreach (var ktp in Liste)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}\t{ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nKitap Adında Seçilen Kelime Geçen Kitapların Sayısı...: " + Liste.Count);
            Console.Write("\nAna Menüye Dönmek İçin Bir Tuşa Basın...");
            Console.ReadKey();

        }

        private static void FiyatAraliginaGoreListele()
        {
            Console.Clear();
            Console.Write("Minimum Fiyat...:");
            decimal minFiyat = decimal.Parse(Console.ReadLine());
            Console.Write("Maksimum Fiyat...:");
            decimal maxFiyat = decimal.Parse(Console.ReadLine());
            var Liste = Kitaplar.Where(p => p.Fiyat >= minFiyat && p.Fiyat <= maxFiyat).ToList();
            Console.WriteLine($"\n{minFiyat:C} - {maxFiyat:C} Fiyat Aralığındaki Kitaplar\n");
            foreach (var ktp in Liste)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}\t{ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nSeçilen Fiyat Aralığındaki Kitapların Sayısı...: " + Liste.Count);
            Console.Write("\nAna Menüye Dönmek İçin Bir Tuşa Basın...");
            Console.ReadKey();
        }

        private static void KategoriyeGoreListele()
        {
            Console.Clear();
            var kategoriler = Kitaplar.GroupBy(p=>p.Kategori).Select(p=>p.Key).ToList();   
            Console.WriteLine("Kategoriler\n");
            int sayac = 1;
            foreach (var ktg in kategoriler)
            {
                Console.WriteLine($"{sayac,2} - {ktg,-20} ");
                sayac++;
            }
            Console.Write("\nSeçiminiz...:");
            int secim = int.Parse(Console.ReadLine());
            string secilenkat= kategoriler[secim-1];
            var Liste = Kitaplar.Where(p=>p.Kategori==secilenkat).Select(p=> new { p.Adi, p.Yazar}).ToList();
            Console.WriteLine($"\n{secilenkat} Kategorisindeki Kitaplar\n");
            foreach (var ktp in Liste)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}");
            }
            Console.WriteLine("\nSeçilen Kategorideki Kitapların Sayısı...: " + Liste.Count);
            Console.Write("\nAna Menüye Dönmek İçin Bir Tuşa Basın...");
            Console.ReadKey();

        }

        private static void KitapAdiYazariSayfaSayisiListele()
        {
            Console.Clear();

            var Liste = Kitaplar.Select(p => new { p.Adi, p.Yazar, p.SayfaSayisi }).ToList();
            Console.WriteLine("Adı, Yazar, ve Sayfa Sayısına Göre Tüm Kitapların Listesi\n");
            foreach (var ktp in Liste)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}\t{ktp.SayfaSayisi,4}");
            }
            Console.Write("\nAna Menüye Dönmek İçin Bir Tuşa Basın...");
            Console.ReadKey();
        }

        private static void TumKitaplariListele()
        {
            Console.Clear();
            foreach (Kitap ktp in Kitaplar)
            {
                ktp.Yazdir();
                

            }
            Console.Write("\nAna Menüye Dönmek İçin Bir Tuşa Basın...");
            Console.ReadKey();
        }
    }
}
