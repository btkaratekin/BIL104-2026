using System;

namespace Ornek10
{
    internal class Program
    {
        /* Örnek: 3 basamaklı narsist sayıları ekrana yazan programı oluşturunuz.
         * 
         * Not: Narsist sayı kontrolü bir fonksiyon tarafından yapılacaktır.
         */
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (NarsistKontrol(i) == true)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();

        }

        static bool NarsistKontrol(int gelensayi)
        {
            int yuzler = gelensayi / 100;
            int onlar = (gelensayi % 100) / 10;
            int birler = (gelensayi % 10);
            int toplam = Convert.ToInt32(Math.Pow(yuzler, 3) + Math.Pow(onlar, 3) + Math.Pow(birler, 3));
            if (toplam == gelensayi)
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
