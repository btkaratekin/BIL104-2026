using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Örnek: 1 ile 1000 arasındaki mükemmel sayıları ekrana yazan programı oluşturunuz.
         * 
         * Not: Mükemmel sayı kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 1000 Arasındaki Mükemmel Sayılar");
            for (int i = 1; i <= 1000; i++)
            {
                if (MukemmelSayiKontrol(i) == true)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();

        }

        static bool MukemmelSayiKontrol(int gelensayi)
        {
            int toplam = 0;
            for (int i = 1; i < gelensayi; i++)
            {
                if ((gelensayi % i) == 0)
                {
                    toplam = toplam + i;
                }

            }
            return toplam == gelensayi ? true : false;
        }
    }
}
