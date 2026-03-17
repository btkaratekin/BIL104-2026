using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir metin ve bu metinde aranacak bir harf alarak, girilen metinde kaç adet bu harfin bulunduğunu bulan programı yazınız. */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin....:");
            string metin = Console.ReadLine();
            Console.Write("Bu Metinde Aranacak Harf..:");
            char aranan = char.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Metinde {0} Harfinden Toplamda {1} Adet Bulunmaktadır.", aranan, HarfSay(metin, aranan));
            Console.ReadKey();
        }
        static int HarfSay(string gelenmetin, char arananharf)
        {
            int sayac = 0;
            for (int i = 0; i < gelenmetin.Length; i++)
            {
                if (gelenmetin[i] == arananharf)
                {
                    sayac++;
                }
            }
            return sayac;
        }
    }
}
