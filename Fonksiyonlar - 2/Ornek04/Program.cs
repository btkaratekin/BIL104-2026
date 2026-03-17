using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir metin alarak, bu metinde kaç adet ünlü harf, kaç adet ünsüz harf bulunduğunu bulan programı yazınız. 
         
         Not: Türkçe'de ünlü harfler A, E, I, İ, O, Ö, U, Ü'dür. Ünsüz harfler ise diğer tüm harflerdir. */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin....:");
            string metin = Console.ReadLine();
            Console.WriteLine("Yukarıdaki Metinde {0} Adet Ünlü, {1} Adet Ünsüz Harf Bulunmaktadır.", HarfSay(metin, "Ünlü"), HarfSay(metin, "Ünsüz"));
            Console.ReadKey();
        }

        static int HarfSay(string gelenmetin, string secim)
        {
            int unlusay = 0, unsuzsay = 0;
            char[] unluharfler = "AEIİOÖUÜaeıioöuü".ToCharArray();
            char[] unsuzharfler = "BCÇDFGĞHJKLMNPRSŞTVYZbcçdfghjklmnprsştvyz".ToCharArray();

            for (int i = 0; i < gelenmetin.Length; i++)
            {
                if (Array.IndexOf(unluharfler, gelenmetin[i]) != -1)
                {
                    unlusay++;
                }
                else if (Array.IndexOf(unsuzharfler, gelenmetin[i]) != -1)
                {
                    unsuzsay++;
                }
            }
            if (secim == "Ünlü")
            {
                return unlusay;
            }
            else
            {
                return unsuzsay;
            }
        }
    }
}
