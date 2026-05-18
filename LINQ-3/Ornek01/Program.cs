using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ornek01
{
    internal class Program
    {
        static List<Kitap> Kitaplar = KitapListe.ListeyiGetir();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LINQ İşlemleri Distinct() ve GroupBy() Metodları Kullanımı");
                Console.WriteLine("\n\nMenü");
                Console.WriteLine("1. Kitap Kategorilerini Listele");
                Console.WriteLine("2. Bilim Kurgu ve Fantastik Türlerinden Kitapları Olan YayınEvlerini Listele");
                Console.WriteLine("3. Farklı Yazarların Listesini (A - Z) ve Toplam Yazar Sayısını Göster");   
                Console.WriteLine("4. Her Bir Yayınevinin Altında Bulunan Kitapları Listele");
                Console.WriteLine("5. Yazarların Kitap Sayılarını Listele");
                Console.WriteLine("6. Basım Yıllarına Göre Kitap Sayılarını Göster");
                Console.WriteLine("7. Çıkış");
                Console.Write("\nSeçiminiz....:");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                           KitapKategoriListele();
                            break;
                        }
                    case 2:
                        {
                            YayinEvleriListele();
                            break;
                        }
                    case 3:
                        {
                            FarkliYazarListele();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("YayınEvlerine Ait Kitaplar Listesi\n");
                            var Liste = Kitaplar.GroupBy(k => k.YayinEvi).Select(g => new { YayinEvi = g.Key, Kitaplar = g.ToList() }).OrderBy(g => g.YayinEvi).ToList();
                            foreach (var yayinEvi in Liste)
                            {
                                Console.WriteLine("* " + yayinEvi.YayinEvi);
                                foreach (var kitap in yayinEvi.Kitaplar)
                                {
                                    Console.WriteLine("\t- " + kitap.Adi);
                                }
                                Console.WriteLine();
                            }
                            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            YazarlarVeKitaplar();

                            break;
                        }
                    case 6:
                        {
                            BasimYiliveKitaplar();

                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Çıkış yapılıyor...");
                            Thread.Sleep(2000);
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Geçersiz Seçim...Tekrar Deneyin...");
                            Thread.Sleep(2000);
                            break;
                        }

                }
            }

        }

        private static void BasimYiliveKitaplar()
        {
            Console.Clear();
            Console.WriteLine("Basım Yıllarına Göre Kitap Sayıları\n");
            var Liste = Kitaplar.GroupBy(x => x.BasimYili).Select(y => new { BasimYili = y.Key, Adet = y.Count() }).OrderBy(x => x.BasimYili).ToList();
            Console.WriteLine($"{"Basım Yılı",-5}     {"Kitap Sayısı",-5}");
            foreach (var ktp in Liste)
            {
                Console.WriteLine($"{ktp.BasimYili,-5}\t\t{ktp.Adet,-5}");
            }
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void YazarlarVeKitaplar()
        {
            Console.Clear();
            Console.WriteLine("Yazarlar ve Yazarlara Ait Kitap Sayıları\n");
            var Liste = Kitaplar.GroupBy(x=>x.Yazar).Select(y=> new {Yazar=y.Key,Adet=y.Count()}).OrderBy(x=>x.Yazar).ToList();
            Console.WriteLine($"{"Yazar Adı",-25}\t{"Kitap Sayısı",-10}");
            foreach (var yazar in Liste)
            {
                Console.WriteLine($"{yazar.Yazar,-25}\t{yazar.Adet,-10}");
            }
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void FarkliYazarListele()
        {
            Console.Clear();
            Console.WriteLine("Farklı Yazarların Listesi\n");
            List<string> FarkliYazarlar = Kitaplar.Select(k => k.Yazar).Distinct().OrderBy(x=>x).ToList();
            foreach (string yazar in FarkliYazarlar)
            {
                Console.WriteLine(" - " + yazar);
            }
            Console.WriteLine("\nToplam Yazar Sayısı...: " + FarkliYazarlar.Count);
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void YayinEvleriListele()
        {
            Console.Clear();
            Console.WriteLine("Bilim Kurgu ve Fantastik Kategorilerinde Kitapları Bulunan YayınEvleri Listesi\n");
            List<string> YayinEvleri = Kitaplar.Where(k => k.Kategori == "Bilim Kurgu" || k.Kategori == "Fantastik").Select(k => k.YayinEvi).Distinct().ToList();
            foreach (string yayinEvi in YayinEvleri)
            {
                Console.WriteLine(" - " + yayinEvi);
            }
            Console.WriteLine("\nToplam YayınEvi Sayısı...: " + YayinEvleri.Count);
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void KitapKategoriListele()
        {
            Console.Clear();
            Console.WriteLine("Kitaplar Listesinde Yer Alan Kitap Kategorileri\n");
             List<string> KitapKategori = Kitaplar.Select(k=>k.Kategori).Distinct().ToList();

            foreach (string ktp in KitapKategori)
            {
                Console.WriteLine(" -"+ktp);
            }
            Console.WriteLine("\nToplam Kategori Sayısı...: " + KitapKategori.Count);
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();

        }
    }
}
