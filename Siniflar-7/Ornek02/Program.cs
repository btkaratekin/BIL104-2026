using Mathematica;
using System;

namespace Ornek02
{
    /* Bu Proje Mathematica Projesinde oluşturulan Mathematica kütüphanesinin kulanımını içermektedir. Kullanılan metodlar Cebirsel sınıfının altında oluşturulmuştur. Mathematica kütüphanesi referans olarak projeye dahil edilmiştir.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Cebirsel cebir = new Cebirsel();
            Console.Write("1. Sayıyı Girin....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Girin....:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Girilen Sayıların EBOB u: " + cebir.EbobHesapla(sayi1, sayi2));
            Console.WriteLine("Girilen Sayıların EKOK u: " + cebir.EkokHesapla(sayi1, sayi2));
            Console.ReadKey();

        }
    }
}
