using System;

namespace Ornek03
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının tek mi çift mi olduğunu ekrana yazan programı oluşturunuz.
         * 
         * Not: Tek mi çift mi olduğunu bulan işlemi bir fonksiyon tarafından yapılacaktır.(Geriye değer döndüren metod)
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin....:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz " + sayi + " Sayısı " + TekCiftKontrol(sayi) + " dir.");
            Console.ReadKey();
            //Console.WriteLine("Girmiş Olduğunuz {0} sayısı {1} dir.", sayi, TekCiftKontrol(sayi));
        }

        static string TekCiftKontrol(int gelensayi)
        {
            //if ((gelensayi % 2) == 0)
            //{
            //    return "Çift";
            //}
            //else
            //{
            //    return "Tek";

            //}
            return gelensayi%2 == 0 ? "Çift" : "Tek";
        }

    }
}
