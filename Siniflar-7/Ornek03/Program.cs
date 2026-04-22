using Mathematica;
using System;

namespace Ornek03
{
    /* Bu Proje Mathematica Projesinde oluşturulan Mathematica kütüphanesinin kulanımını içermektedir. Kullanılan metodlar Cebirsel sınıfının altında oluşturulmuştur. Mathematica kütüphanesi referans olarak projeye dahil edilmiştir.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Cebirsel cebir = new Cebirsel();
            Console.Write("Kaç Adet Sayı Gireceksiniz.....:");
            int adet = int.Parse(Console.ReadLine());
            double[] sayilar = new double[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Girin.....:");
                sayilar[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz Sayıların Aritmetik Ortalaması...: " + cebir.AortHesapla(sayilar).ToString("0.##"));
            Console.WriteLine("Girdiğiniz Sayıların Geometrik Ortlaması....: " + cebir.GortHesapla(sayilar).ToString("0.##"));
            Console.ReadKey();

        }
    }
}
