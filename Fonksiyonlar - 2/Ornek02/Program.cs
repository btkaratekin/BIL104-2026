using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan 10 adet sayı alarak bu sayıların kaç tanesinin tek, kaç tanesinin çift olduğunu bulan programı yazınız. 
         
         Not: Tek sayılar 2'ye bölündüğünde kalan 1 olan sayılardır. Çift sayılar ise 2'ye bölündüğünde kalan 0 olan sayılardır. */
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Girin....:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Sayıların {0} Tanesi Tek, {1} Tanesi ise Çifttir.", TekCiftSay(sayilar, 15), TekCiftSay(sayilar, 2));
            Console.ReadKey();
        }

        static int TekCiftSay(int[] gelensayilar, int secim)
        {
            int teksay = 0, ciftsay = 0;

            for (int i = 0; i < gelensayilar.Length; i++)
            {
                if ((gelensayilar[i] % 2) == 1)
                {
                    teksay++;
                }
                else
                {
                    ciftsay++;
                }
            }
            if (secim == 1)
            {
                return teksay;
            }
            else if (secim == 2)
            {
                return ciftsay;
            }
            else
            {
                return -1;
            }
        }
    }
}
