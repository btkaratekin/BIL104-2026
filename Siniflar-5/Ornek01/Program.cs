using System;

namespace Ornek01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekil ucgen = new Sekil("Üçgen");
            ucgen.CevreHesapla(3, 4, 5);
            ucgen.AlanHesapla(3, 4);
            Console.WriteLine();
            Sekil dikdortgen = new Sekil("Dikdörtgen");
            dikdortgen.CevreHesapla(5, 9);
            dikdortgen.AlanHesapla(5.0, 9.0);
            Console.WriteLine();
            Sekil kare = new Sekil("Kare");
            kare.CevreHesapla(6);
            kare.AlanHesapla(6);
            Console.WriteLine();
            Sekil daire = new Sekil("Daire");
            daire.CevreHesapla(Convert.ToDouble(6));
            daire.AlanHesapla(Convert.ToDouble(6));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
