using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan iki sayı alarak bu sayıların toplamını ekrana yazdıran bir metot yazınız. */

        static void Main(string[] args)
        {
            SayilariTopla();
            Console.ReadKey();
        }
        static void SayilariTopla()
        {
            Console.Write("1. Sayıyı Girin....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Girin.....:");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("İşlemin Sonucu....:" + toplam);
        }
    }
}
