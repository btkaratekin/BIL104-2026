using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının asal olup olmadığını ekrana yazan programı oluşturunuz.
         * 
         * Not: Asallık kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin...:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz {0} Sayısı {1} dir.", sayi, AsalKontrol(sayi));
            Console.ReadKey();
        }

        static string AsalKontrol(int gelensayi)
        {
            bool Asal = true;

            for (int i = 2; i < gelensayi; i++)
            {
                if ((gelensayi % i) == 0)
                {
                    Asal = false;
                    break;
                }
            }
            if (Asal == true)
            {
                return "Asal";
            }
            else
            {
                return "Asal Değil";
            }
        }
    }
}
