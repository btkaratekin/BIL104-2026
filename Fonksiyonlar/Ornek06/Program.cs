using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: 1 ile 100 arasındaki asal sayıları ekrana yazan programı oluşturunuz.
         * 
         * Not: Asallık kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 100 Arasındaki Asal Sayılar");
            for (int i = 2; i <= 100; i++)
            {
                if (AsalKontrol(i) == true)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadKey();
        }
        static bool AsalKontrol(int gelensayi)
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
            return Asal;
        }
    }
}
