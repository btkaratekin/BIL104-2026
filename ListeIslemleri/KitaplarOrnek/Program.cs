using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KitaplarOrnek
{
    internal class Program
    {
        static List<Kitap> Kitaplar = KitapListe.ListeyiGetir();

        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
           
            AnaMenu();
        }

        static void Listele()
        {
            Console.Clear();
            foreach (Kitap ktp in Kitaplar)
            {
                ktp.Yazdir();
            }
            Console.WriteLine("\nListedeki Kitapların Sayısı..: " + Kitaplar.Count);
            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();

        }

        static void AnaMenu()
        {
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Kitap İşlemleri");
                Console.WriteLine("1 - Kitap Ekle");
                Console.WriteLine("2 - Kitapları Listele");
                Console.WriteLine("3 - Kitap Sil");
                Console.WriteLine("4 - Kitap Sorgula");
                Console.WriteLine("5 - Kitap Kategorileri Listesi");
                Console.WriteLine("6 - Çıkış");
                Console.Write("\nSeçiminiz...: ");
                int secim = int.Parse(Console.ReadLine());

                if (secim == 2)
                {
                    Listele();
                }
                else if (secim == 6)
                {
                    Console.Write("\nProgram Sonu...");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Bir Menü Seçimi Yaptınız. Ana Menüye Yönlendirileceksiniz..");
                    Thread.Sleep(2000);

                }
            }
        }
    }
}
