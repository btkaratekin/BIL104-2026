using System;

namespace Ornek03
{
    internal class Daire : Sekil
    {
        double yaricap;
        public Daire(double gelenyaricap)
        {
            yaricap = gelenyaricap;
        }
        public override void CevreHesapla()
        {
            double cevre = 2 * Math.PI * yaricap;
            Console.Write("Dairenin ");
            base.CevreHesapla();
            Console.WriteLine(cevre.ToString("F2"));
        }
        public override void AlanHesapla()
        {
            double alan = Math.PI * Math.Pow(yaricap, 2);
            Console.Write("Dairenin ");
            base.AlanHesapla();
            Console.WriteLine(alan.ToString("F2"));
        }


    }
}
