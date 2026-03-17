using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının mükemmel sayı olup olmadığını ekrana yazan programı oluşturunuz.
         * 
         * Not: Mükemmel sayı kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin....:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz {0} Sayısı {1} dir.", sayi, MukkemmelSayi(sayi));
            Console.ReadKey();
        }

        static string MukkemmelSayi(int gelensayi)
        {

            int toplam = 0;
            for (int i = 1; i < gelensayi; i++)
            {
                if ((gelensayi % i) == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (gelensayi == toplam)
            {
                return "Mükemmel Sayı";
            }
            else
            {
                return "Mükemmel Sayı Değil";

            }

        }
    }
}
