using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 2 adet Sayının toplamını ekrana yazan programı oluşturunuz.
         * 
         * Not: Toplam işlemi bir fonksiyon tarafından yapılacaktır.(Geriye değer döndüren metod)
         */

        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = Topla(sayi1, sayi2);
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadKey();
        }
        static int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
