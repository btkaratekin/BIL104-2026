using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının faktöriyelini hesaplayan programı oluşturunuz.
         * 
         * Not: Faktöriyel hesaplama işlemini bir fonksiyon tarafından yapılacaktır.(Geriye değer döndüren metod)
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin....:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz " + sayi + " Sayısının Faktöriyeli....:" + FaktoriyelHesapla(sayi).ToString("N"));
            Console.ReadKey();
        }

        static long FaktoriyelHesapla(int gelensayi)
        {
            long fakt = 1;
            for (int i = 1; i <= gelensayi; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
    }
}
