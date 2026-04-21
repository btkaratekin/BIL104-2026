using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin.....:");
            double sayi = double.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Sayının Karekökü....:" + YaklasikKarekok(sayi).ToString("F3"));
            // Console.WriteLine("Girdiğiniz Sayının Karekökü " + (YaklasikKarekok(sayi)-1) + " ile " + YaklasikKarekok(sayi) + " Arasındadır.");
            Console.ReadKey();
        }
        static double YaklasikKarekok(double gelensayi)
        {
            double sonuc = 1;
            while ((sonuc * sonuc) < gelensayi)
            {
                sonuc++;
            }

            for (double i = (sonuc - 1); i <= sonuc; i = i + 0.001)
            {
                if ((i * i) >= gelensayi)
                {
                    sonuc = i;
                    break;
                }
            }

            //for (int i = 1;  i<gelensayi; i++)
            //{
            //    if ((i*i)>=gelensayi)
            //    {
            //        sonuc = i;
            //        break;
            //    }
            //}
            return sonuc;
        }
    }
}
