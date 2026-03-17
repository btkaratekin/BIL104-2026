using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {
        /* Örnek: 4 basamaklı palindromik sayıları ekrana yazan programı oluşturunuz.
         * 
         * Not: Palindromik sayı kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("4 Basamaklı Palindromik Sayılar");
            for (int i = 1000; i < 10000; i++)
            {
                if (PalindromikKontrol(i) == true)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();
        }
        static bool PalindromikKontrol(int gelensayi)
        {
            int binler = gelensayi / 1000;
            int yuzler = (gelensayi % 1000) / 100;
            int onlar = (gelensayi % 100) / 10;
            int birler = (gelensayi % 10);

            if ((binler == birler) && (yuzler == onlar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
