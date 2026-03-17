using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan 10 adet sayı alarak bu sayıların aritmetik ortalamasını hesaplayan programı yazınız. 
         
         Not: Aritmetik ortalama, sayıların toplamının, sayı adedine bölünmesiyle bulunur. */
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Girin....:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Sayıların Aritmetik Ortalaması " + AortHesapla(sayilar) + " dir.");
            Console.ReadLine();
        }
        static double AortHesapla(int[] gelensayilar)
        {
            double toplam = 0;
            for (int i = 0; i < gelensayilar.Length; i++)
            {
                toplam = toplam + gelensayilar[i];
            }
            double Aort = toplam / gelensayilar.Length;
            return Aort;
        }
    }
}
