using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan 10 adet sayı alarak, bu sayıların tek olanlarını ve çift olanlarını ayrı ayrı listeleyen programı yazınız. */
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(i + 1 + ". Sayıyı Girin....:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nİşlemler\n1 - Tek Sayıları Listele\n2 - Çift Sayıları Listele\n\nSeçiminiz..: ");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                int[] tekler = Listele(sayilar, true);
                Console.Write("Girdiğiniz Sayılardan Tek Olanlar....:");
                for (int i = 0; i < tekler.Length; i++)
                {
                    Console.Write(tekler[i] + ",");
                }
            }
            else if (secim == 2)
            {
                int[] ciftler = Listele(sayilar, false);
                Console.Write("Girdiğiniz Sayılardan Çift Olanlar....:");
                for (int i = 0; i < ciftler.Length; i++)
                {
                    Console.Write(ciftler[i] + ",");
                }
            }
            else
            {
                Console.Write("Yanlış Seçim Yaptınız.");
            }
            Console.ReadKey();
        }
        static int[] Listele(int[] gelensayilar, bool islem)
        {

            int[] teksayilar = new int[gelensayilar.Length];
            int[] ciftsayilar = new int[gelensayilar.Length];
            Array.Sort(gelensayilar);
            int sayactek = 0, sayaccift = 0;
            for (int i = 0; i < gelensayilar.Length; i++)
            {
                if ((gelensayilar[i] % 2) == 0)
                {
                    ciftsayilar[sayaccift] = gelensayilar[i];
                    sayaccift++;
                }
                else
                {
                    teksayilar[sayactek] = gelensayilar[i];
                    sayactek++;
                }
            }
            if (islem == true)
            {
                Array.Resize(ref teksayilar, sayactek);
                return teksayilar;
            }
            else
            {
                Array.Resize(ref ciftsayilar, sayaccift);
                return ciftsayilar;
            }
        }
    }
}
