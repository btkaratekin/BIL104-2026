using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen 2 adet Sayının büyük olanını ekrana yazan programı oluşturunuz.
         * 
         * Not: Büyük olan sayıyı bulan işlemi bir fonksiyon tarafından yapılacaktır.(Geriye değer döndüren metod)
         */
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Girin....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Girin....:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz Bu Sayılardan Büyük Olanı " + BuyukSayi(sayi1, sayi2) + " dir.");
            Console.ReadKey();

        }
        static int BuyukSayi(int gs1, int gs2)
        {

            if (gs1 > gs2)
            {
                return gs1;
            }
            else
            {
                return gs2;
            }

            //return gs1 > gs2 ? gs1 : gs2;

        }

    }
}
