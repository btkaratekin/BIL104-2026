using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan iki adet sayı alarak, bu sayılar arasında rastgele bir sayı üreten programı yazınız. 
         
         Not: Rastgele sayı üretmek için Random sınıfını kullanabilirsiniz. Random sınıfının Next() metodu, belirli bir aralıkta rastgele bir tam sayı üretir. Örneğin, rnd.Next(1, 100) ifadesi 1 ile 99 arasında rastgele bir tam sayı üretir. */
        static void Main(string[] args)
        {
            Console.Write("Rastgele Üretilecek Sayı Aralığının\nBaşlangıç Değerini Girin.....:");
            int bas = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Değerini Girin.........:");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayınız......: " + RastgeleSayiUret(bas, bit));
            Console.ReadKey();
        }
        static int RastgeleSayiUret(int baslangic, int bitis)
        {
            Random rnd = new Random();
            return rnd.Next(baslangic, bitis);
        }
    }
}
