using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir sayı alarak, bu sayının pozitif tam bölenlerini bulan programı yazınız. 
         
         Not: Pozitif tam bölenler, bir sayıyı tam olarak bölen ve pozitif olan sayılardır. Örneğin, 12 sayısının pozitif tam bölenleri 1, 2, 3, 4, 6 ve 12'dir. */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin....:");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write(sayi + " Sayısının Pozitif Tam Bölenleri.....:");
            int[] Ptb = PozitifTamBolenler(sayi);
            for (int i = 0; i < Ptb.Length; i++)
            {
                Console.Write(Ptb[i] + ",");
            }

            Console.ReadLine();
        }

        static int[] PozitifTamBolenler(int gelensayi)
        {
            int[] tamBolenler = new int[gelensayi];
            int sayac = 0;
            for (int i = 1; i <= gelensayi; i++)
            {
                if ((gelensayi % i) == 0)
                {
                    tamBolenler[sayac] = i;
                    sayac++;
                }
            }
            Array.Resize(ref tamBolenler, sayac);
            return tamBolenler;
        }
    }
}
