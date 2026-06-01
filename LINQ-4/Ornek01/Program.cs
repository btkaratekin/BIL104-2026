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
                Console.WriteLine("LINQ İşlemleri Sum(),Average(),Min(),Max(),Count(),FirstOrDefault() ve LastOrDefault() Metodları Kullanımı");
                Console.WriteLine("\n\nMenü");
                Console.WriteLine("1. Bilim Kurgu Kategorisindeki Kitapların Toplam Fiyatını Göster");
                Console.WriteLine("2. İş Bankası Kültür Yayınlarından Çıkan Kitapların Ortalama Fiyatını Göster");
                Console.WriteLine("3. 1950 ile 2000 Yılları Arasında Yayınlanan En Pahalı Kitabı Göster");
                Console.WriteLine("4. Listedeki En Yeni Kitabın Basım Yılını Göster");
                Console.WriteLine("5. Şiir Kategorisindeki En Ucuz Kitabı Göster");
                Console.WriteLine("6. Sayfa Sayısı 250 den Az Olan Kitapların Kategorileri ve Kitap Sayılarını Göster");
                Console.WriteLine("7. Çıkış");
                Console.Write("\nSeçiminiz....:");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            BilimKurguToplamFiyatGoster();
                            break;
                        }
                    case 2:
                        {
                            YayinEvineGoreOrtalamaFiyatGoster();
                            break;
                        }
                    case 3:
                        {
                            EnPahaliKitapGoster();
                            break;
                        }
                    case 4:
                        {
                            EnYeniKitapGoster();
                            break;
                        }
                    case 5:
                        {

                            EnUcuzSiirKitapGoster();
                            break;
                        }
                    case 6:
                        {

                            SayfaSayisinaGoreKitaplarVeKategoriler();
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

        private static void SayfaSayisinaGoreKitaplarVeKategoriler()
        {
            Console.Clear();
            Console.WriteLine("Sayfa Sayısı 250 den Az Olan Kitapların Kategorileri ve Kitap Sayıları\n");
            var Liste = Kitaplar.Where(x => x.SayfaSayisi <= 250).GroupBy(y => y.Kategori).Select(z => new { Kategori = z.Key, KitapSayisi = z.Count() }).ToList();
            foreach (var kat in Liste)
            {
                Console.WriteLine($"{kat.Kategori,-20} {kat.KitapSayisi,3}");
            }
            Console.WriteLine("\n250 nin altında Sayfa Sayısı Olan Kitap Kategorilerinin Sayısı..: " + Liste.Count);
            Console.WriteLine("\n250 nin altında Sayfa Sayısına Sahip Toplam Kitap Sayısı........: " + Liste.Sum(x => x.KitapSayisi));
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void EnUcuzSiirKitapGoster()
        {
            Console.Clear();
            Console.WriteLine("Listedeki En Ucuz Şiir Kitap Bilgisi\n");
            decimal EnUcuzSiirKitabi = Kitaplar.Where(x => x.Kategori == "Şiir").Min(x => x.Fiyat);
            Kitap EnUcuzSiirKitap = Kitaplar.FirstOrDefault(x => x.Fiyat == EnUcuzSiirKitabi && x.Kategori == "Şiir");
            Console.WriteLine("En Ucuz Şiir Kitap");
            Console.WriteLine("Adı........: " + EnUcuzSiirKitap.Adi);
            Console.WriteLine("Yazarı.....: " + EnUcuzSiirKitap.Yazar);
            Console.WriteLine("YayınEvi...: " + EnUcuzSiirKitap.YayinEvi);
            Console.WriteLine("Kategori...: " + EnUcuzSiirKitap.Kategori);
            Console.WriteLine("Basım Yılı.: " + EnUcuzSiirKitap.BasimYili);
            Console.WriteLine("Fiyat......: " + EnUcuzSiirKitap.Fiyat.ToString("C"));

            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void EnYeniKitapGoster()
        {
            Console.Clear();
            Console.WriteLine("Listedeki En Yeni Kitap Bilgisi\n");
            int enyenibasimyili = Kitaplar.Max(x => x.BasimYili);
            Kitap EnYeniKitap = Kitaplar.FirstOrDefault(x => x.BasimYili == enyenibasimyili);
            Console.WriteLine("En Yeni Kitap");
            Console.WriteLine("Adı........: " + EnYeniKitap.Adi);
            Console.WriteLine("Yazarı.....: " + EnYeniKitap.Yazar);
            Console.WriteLine("YayınEvi...: " + EnYeniKitap.YayinEvi);
            Console.WriteLine("Kategori...: " + EnYeniKitap.Kategori);
            Console.WriteLine("Basım Yılı.: " + EnYeniKitap.BasimYili);
            Console.WriteLine("Fiyat......: " + EnYeniKitap.Fiyat.ToString("C"));

            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void EnPahaliKitapGoster()
        {
            Console.Clear();
            Console.WriteLine("1950 - 2000 Yılları Arasında Yayınlanan En Pahalı Kitap Bilgisi\n");
            Kitap EnPahaliKitap = Kitaplar.Where(x => x.BasimYili >= 1950 && x.BasimYili <= 2000).OrderBy(y => y.Fiyat).LastOrDefault();
            
           

            Console.WriteLine("En Pahalı Kitap");
            Console.WriteLine("Adı........: " + EnPahaliKitap.Adi);
            Console.WriteLine("Yazarı.....: " + EnPahaliKitap.Yazar);
            Console.WriteLine("YayınEvi...: " + EnPahaliKitap.YayinEvi);
            Console.WriteLine("Kategori...: " + EnPahaliKitap.Kategori);
            Console.WriteLine("Basım Yılı.: " + EnPahaliKitap.BasimYili);
            Console.WriteLine("Fiyat......: " + EnPahaliKitap.Fiyat.ToString("C"));

            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void YayinEvineGoreOrtalamaFiyatGoster()
        {
            Console.Clear();
            Console.WriteLine("İş Bankası Kültür Yayınlarından Çıkan Kitapların Ortalama Fiyat Bilgisi\n");
            var IsBankasiKitaplari = Kitaplar.Where(x => x.YayinEvi == "İş Bankası Kültür Yayınları").Select(y => new { y.Adi, y.Yazar, y.Fiyat }).ToList();
            foreach (var ktp in IsBankasiKitaplari)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}\t{ktp.Fiyat,6:C}");
            }
            decimal ortalamaFiyat = IsBankasiKitaplari.Average(x => x.Fiyat);
            Console.WriteLine($"\nBu Yayın Evindeki Kitapların Ortalama Fiyatı: {ortalamaFiyat:C}");
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void BilimKurguToplamFiyatGoster()
        {
            Console.Clear();
            Console.WriteLine("Bilim Kurgu Kategorisindeki Kitapların Toplam Fiyat Bilgisi\n");
            var BilimKurguKitaplari = Kitaplar.Where(x => x.Kategori == "Bilim Kurgu").Select(y => new { y.Adi, y.Yazar, y.Fiyat }).ToList();
            foreach (var ktp in BilimKurguKitaplari)
            {
                Console.WriteLine($"{ktp.Adi,-35}\t{ktp.Yazar,-25}\t{ktp.Fiyat,6:C}");
            }
            decimal toplamfiyat = BilimKurguKitaplari.Sum(x => x.Fiyat);
            Console.WriteLine($"\nBu Kategorideki Kitapların Toplam Fiyatı: {toplamfiyat:C}");
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }
    }
}
