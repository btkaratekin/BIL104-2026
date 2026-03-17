using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan üç sayı alarak bu sayıların en küçüğünü ekrana yazdıran bir metot yazınız. */
        static void Main(string[] args)
        {
            EnKucukSayiyiBul();
            Console.ReadKey();
            Console.Clear();
            EnKucukSayiyiBul();
            Console.ReadKey();
        }
        static void EnKucukSayiyiBul()
        {
            Console.Write("1. Sayıyı Girin.....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Girin.....:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Girin.....:");
            int sayi3 = int.Parse(Console.ReadLine());
            int ek = sayi1;
            if (sayi2 < ek)
            {
                ek = sayi2;
            }
            if (sayi3 < ek)
            {
                ek = sayi3;
            }
            Console.WriteLine("Girdiğiniz Sayılardan En Küçük Olanı....:" + ek);

        }
    }
}
