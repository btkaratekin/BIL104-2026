using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen t1 = new Ucgen(3, 4, 5);
            t1.CevreHesapla();
            t1.AlanHesapla();
            Console.WriteLine();
            Kare s1 = new Kare(6);
            s1.CevreHesapla();
            s1.AlanHesapla();
            Console.WriteLine();
            Daire c1 = new Daire(9);
            c1.CevreHesapla();
            c1.AlanHesapla();
            Console.ReadKey();
        }
    }
}
