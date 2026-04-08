using System;

namespace Ornek03
{
    internal class Ucgen : Sekil
    {
        int kenar1;
        int kenar2;
        int kenar3;

        /// <summary>
        /// Bir Üçgen Oluşturulmasını Sağlar.
        /// </summary>
        /// <param name="a">1. Kenar</param>
        /// <param name="b">2. Kenar</param>
        /// <param name="c">3. Kenar</param>
        public Ucgen(int a, int b, int c)
        {
            kenar1 = a;
            kenar2 = b;
            kenar3 = c;
        }

        public override void CevreHesapla()
        {
            int cevre = kenar1 + kenar2 + kenar3;
            Console.Write("Üçgenin ");
            base.CevreHesapla();
            Console.WriteLine(cevre);
        }
        public override void AlanHesapla()
        {
            Console.WriteLine("1. Kenar: {0}\n2. Kenar:{1}\n3. Kenar:{2}", kenar1, kenar2, kenar3);
            Console.Write("Bu Üçgenin Taban Kenarı Hangisidir?:");
            int kno = int.Parse(Console.ReadLine());
            Console.Write("Bu Üçgenin Yüksekliği Kaçtır?...:");
            yukseklik = int.Parse(Console.ReadLine());
            if (kno == 1)
            {
                taban = kenar1;
            }
            else if (kno == 2)
            {
                taban = kenar2;

            }
            else
            {
                taban = kenar3;
            }
            int alan = taban * yukseklik / 2;

            Console.Write("Bu Üçgenin ");
            base.AlanHesapla();
            Console.WriteLine(alan);
        }
    }
}
