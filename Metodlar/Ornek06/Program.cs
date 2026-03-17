using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notlar = new int[20, 3];
            DiziDoldur(notlar);
            AnaMenu(notlar);
        }
        static void DiziDoldur(int[,] gelennotlar)
        {
            Random rnd = new Random();

            for (int i = 0; i < gelennotlar.GetLength(0) / 2; i++)
            {
                gelennotlar[i, 0] = rnd.Next(250102001, 250102051);
                gelennotlar[i, 1] = rnd.Next(100) + 1;
                gelennotlar[i, 2] = rnd.Next(100) + 1;
            }
        }
        static void AnaMenu(int[,] gelennotlar)
        {

            bool durum = true;
            while (durum == true)
            {
                Console.Clear();
                Console.WriteLine("UYGULAMA MENÜSÜ\n1 - Kayıt Ekle\n2 - Kayıtları Listele\n3 - Kayıt Sil\n4 - Kayıt Ara\n5 - Çıkış\n");
                Console.Write("Seçiminiz....: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            KayitEkle(gelennotlar);
                            break;
                        }
                    case 2:
                        {
                            KayitListele(gelennotlar);
                            Console.Write("\nDevam Etmek İçin Bir Tuşa Basın...");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            KayitSil(gelennotlar);
                            break;
                        }
                    case 4:
                        {
                            KayitAra(gelennotlar);
                            break;
                        }
                    case 5:
                        {
                            durum = false;
                            break;
                        }

                    default:
                        {
                            Console.Write("Yanlış Seçim");
                            break;
                        }
                }
            }

        }
        static void KayitEkle(int[,] gelennotlar)
        {
            Console.Clear(); Console.Write("Öğrenci No.....:");
            int ogrno = int.Parse(Console.ReadLine());
            Console.Write("Vize Notu....:");
            int vize = int.Parse(Console.ReadLine());
            Console.Write("Final Notu...:");
            int final = int.Parse(Console.ReadLine());
            Console.Write("Girdiğiniz Notları Kaydetmek İstiyor musunuz?:");
            char secim = char.Parse(Console.ReadLine());
            if (char.ToUpper(secim) == 'E')
            {
                for (int i = 0; i < gelennotlar.Length; i++)
                {
                    if (gelennotlar[i, 0] == 0)
                    {
                        gelennotlar[i, 0] = ogrno;
                        gelennotlar[i, 1] = vize;
                        gelennotlar[i, 2] = final;
                        Console.Write("Kayıt Eklendi.");
                        Thread.Sleep(2000);
                        break;

                    }
                }
            }
        }
        static void KayitListele(int[,] gelennotlar)
        {
            Console.Clear();
            Console.WriteLine("Listede Kayıtlı Olan Öğrenciler\n");
            Console.WriteLine("Öğrenci No\tVize\tFinal\tBaşarı Notu");
            for (int i = 0; i < gelennotlar.GetLength(0); i++)
            {
                if (gelennotlar[i, 0] == 0)
                {
                    continue;
                }
                int bnot = gelennotlar[i, 1] * 40 / 100 + gelennotlar[i, 2] * 60 / 100;
                Console.WriteLine(gelennotlar[i, 0] + "\t" + gelennotlar[i, 1] + "\t" + gelennotlar[i, 2] + "\t" + bnot);
            }

        }
        static void KayitSil(int[,] gelennotlar)
        {
            KayitListele(gelennotlar);
            Console.Write("\nKaydını Silmek İstediğiniz\nÖğrencinin Numarası..:");
            int ogrno = int.Parse(Console.ReadLine());
            int ks = 0;
            for (int i = 0; i < gelennotlar.GetLength(0); i++)
            {
                if (ogrno == gelennotlar[i, 0])
                {
                    gelennotlar[i, 0] = 0;
                    gelennotlar[i, 1] = 0;
                    gelennotlar[i, 2] = 0;
                    ks++;
                }
            }
            if (ks > 0)
            {
                Console.WriteLine("Kayıtlar Başarıyla Silindi...");
            }
            Console.Write("Devam Etmek İçin Bir Tuşa Basın..:");

            Console.ReadKey();
        }
        static void KayitAra(int[,] gelennotlar)
        {
            KayitListele(gelennotlar);
            Console.Write("Aramak İstediğiniz\nÖğrencinin Numarası..:");
            int ogrno = int.Parse(Console.ReadLine());
            int ks = 0;
            for (int i = 0; i < gelennotlar.GetLength(0); i++)
            {
                if (ogrno == gelennotlar[i, 0])
                {
                    ks++;
                    int bnot = gelennotlar[i, 1] * 40 / 100 + gelennotlar[i, 2] * 60 / 100;
                    Console.WriteLine(gelennotlar[i, 0] + "\t" + gelennotlar[i, 1] + "\t" + gelennotlar[i, 2] + "\t" + bnot);
                }
            }
            if (ks > 0)
            {
                Console.WriteLine("\nGirdiğiniz Öğrenci Numarasına Ait " + ks + " Adet Kayıt Bulundu.");
            }
            else
            {
                Console.Write("\nGirdiğiniz Öğrenci Numarasına Ait Bir Kayıt Bulunamadı.\nDevam Etmek İçin Bir Tuşa Basın....");
            }
            Console.ReadKey();
        }
    }
}
