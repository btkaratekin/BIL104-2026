using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir metin alarak bu metindeki kelimelerin ilk harflerini büyük yaparak ekrana yazdıran bir metot yazınız. */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin....:");
            string metin = Console.ReadLine();
            KelimeleriDuzenle(metin);
            Console.ReadKey();
        }
        static void KelimeleriDuzenle(string gelencumle)
        {
            string[] kelimeler = gelencumle.Split(' ');
            string yeniCumle = null;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                yeniCumle = yeniCumle + " " + ilkHarfBuyut(kelimeler[i]);
            }
            Console.WriteLine("Girilen Cümlenin Kelimelerinin Düzenlenmiş Hali..:" + yeniCumle.Trim());
        }
        static string ilkHarfBuyut(string gelenkelime)
        {
            string yenikelime = char.ToUpper(gelenkelime[0]) + gelenkelime.Substring(1);
            return yenikelime;
        }
    }
}
