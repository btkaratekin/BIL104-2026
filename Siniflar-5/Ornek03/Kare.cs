using System;

namespace Ornek03
{
    internal class Kare : Sekil
    {
        public Kare(int kenar)
        {
            taban = kenar;
            yukseklik = kenar;
        }

        public override void CevreHesapla()
        {
            int cevre = taban * 4;
            Console.Write("Karenin ");
            base.CevreHesapla();
            Console.WriteLine(cevre);
        }
        public override void AlanHesapla()
        {
            int alan = taban * yukseklik;
            Console.Write("Karenin ");
            base.AlanHesapla();
            Console.WriteLine(alan);
        }
    }
}
