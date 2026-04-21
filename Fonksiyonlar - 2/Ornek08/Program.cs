using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Açıklama: Bir sayının karekökünü bulmak için 1’den başlayarak ardışık doğal sayıların kareleri alınır. Karelerden biri verilen sayıya eşit ya da ondan büyük olduğunda, sayının karekökünün bu sayının bir eksiği ile kendisi arasında olduğu anlaşılır.”
         * Örneğin 22 sayısı için 1 den başlandığında 5 sayısının karesi 25 olduğu için 22 sayısının karekökünün 4 ile 5 arasında olduğu anlaşılır.
         
        Soru: Klavyeden girilen bir sayının yaklaşık karekökünü ekrana yazan programı yazınız. 
        Not: yaklaşık değeri bulmak için bu iki sayının arasından virgülden sonra 3 basamak hassasiyetle yaklaşık sonucun taranması gerekmektedir. Ve bu işlem bir fonksiyon tarafından yapılacaktır. */

        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin.....:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayının Karekökü ~= " + KareKok(sayi).ToString("N2"));
            Console.ReadKey();
        }
        static double KareKok(int sayi)
        {
            int i = 1;
            while (i * i <= sayi)
            {
                i++;
            }
            double altSinir = i - 1;
            double ustSinir = i;
            double karekok = altSinir;
            for (int j = 0; j < 1000; j++)
            {
                karekok += 0.001;
                if (karekok * karekok >= sayi)
                {
                    break;
                }
            }
            return karekok;
        }
    }
}
