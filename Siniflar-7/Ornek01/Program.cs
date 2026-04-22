using Mathematica;
using System;

namespace Ornek01
{
    /* Bu Proje Mathematica Projesinde oluşturulan Mathematica kütüphanesinin kulanımını içermektedir. Kullanılan metodlar Cebirsel sınıfının altında oluşturulmuştur. Mathematica kütüphanesi referans olarak projeye dahil edilmiştir.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Cebirsel cebir = new Cebirsel();
            Console.Write("Bir Sayı Girin......:");
            int sayi = int.Parse(Console.ReadLine());
            if (cebir.TekCift(sayi) == true)
            {
                Console.WriteLine("Girdiğiniz Sayı.....: Çift");

            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı.....: Tek");
            }
            if (cebir.AsalKontrol(sayi) == true)
            {
                Console.WriteLine("Girdiğiniz Sayı.....: Asal");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı.....: Asal Değil");
            }

            Console.WriteLine("Sayının Faktöriyeli.: " + cebir.FaktoriyelHesapla(Convert.ToUInt32(sayi)).ToString("N0"));
            Console.ReadKey();

        }
    }
}
