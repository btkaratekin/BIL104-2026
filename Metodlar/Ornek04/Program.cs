using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir metin alarak bu metinde en çok kullanılan harfi ekrana yazdıran bir metot yazınız. */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin....:");
            string metin = Console.ReadLine();
            Console.WriteLine("Girdiğiniz Metinde En Çok Kullanılan Harf {0} dir.", HarfSay(metin));
            Console.ReadLine();
        }
        static string HarfSay(string gelenmetin)
        {
            string alfabe = "ABCÇDEFGĞHIİKLMNOÖPRSŞTUÜVYZ";
            gelenmetin = gelenmetin.ToUpper();

            string eckh = "";
            int eckhsayac = 0;

            for (int i = 0; i < alfabe.Length; i++)
            {
                int sayac = 0;
                for (int j = 0; j < gelenmetin.Length; j++)
                {
                    if (alfabe[i] == gelenmetin[j])
                    {
                        sayac++;
                    }
                }
                if (sayac >= eckhsayac)
                {
                    eckhsayac = sayac;
                    eckh = alfabe[i].ToString();
                }
            }
            return eckh;
        }
    }
}
