using System;

namespace Ornek01
{
    class Sekil
    {
        string sekil;
        public Sekil(string sekilturu)
        {
            sekil = sekilturu;
            Console.WriteLine("Ben Bir " + sekil + " im.");
        }
        public void CevreHesapla()
        {
            Console.WriteLine("Bu Geometrik Şekil İçin Çevre Hesabı Yapılamaz.");
        }
        /// <summary>
        /// Bu Yontem Bir Üçgen İçin Çevre Hesabı Yapar.
        /// </summary>
        /// <param name="a">1. Kenar</param>
        /// <param name="b">2. Kenar</param>
        /// <param name="c">3. Kenar</param>
        public void CevreHesapla(int a, int b, int c)
        {
            int cevre = a + b + c;
            Console.WriteLine("Üçgenin Çevresi...:" + cevre);
        }
        public void AlanHesapla(int taban, int yukseklik)
        {
            int alan = (taban * yukseklik) / 2;
            Console.WriteLine("Üçgenin Alanı.....:" + alan);
        }
        /// <summary>
        /// Burada Bir Dikdörtgen İçin Çevre Hesabı Yapılmaktadır.
        /// </summary>
        /// <param name="kenar1">1. Kenar Uzunluğu</param>
        /// <param name="kenar2">2. Kenar Uzunluğu</param>
        public void CevreHesapla(int kenar1, int kenar2)
        {
            //2 * (a+b)
            int cevre = 2 * (kenar1 + kenar2);
            Console.WriteLine("Dikdörtgenin Çevresi..:" + cevre);
        }

        public void AlanHesapla(double taban, double yukseklik)
        {
            double alan = taban * yukseklik;
            Console.WriteLine("Dikdörtgenin Alanı...:" + alan.ToString("F2"));
        }
        public void CevreHesapla(int kenar)
        {
            int cevre = 4 * kenar;
            Console.WriteLine("Karenin Çevresi......:" + cevre);
        }
        public void AlanHesapla(int kenar)
        {
            int alan = kenar * kenar;
            Console.WriteLine("Karenin Alanı........:" + alan);
        }

        public void CevreHesapla(double yaricap)
        {
            double cevre = 2 * Math.PI * yaricap;
            Console.WriteLine("Dairenin Çevresi.....:" + cevre.ToString("F2"));

        }
        public void AlanHesapla(double yaricap)
        {
            double alan = Math.PI * Math.Pow(yaricap, 2);
            Console.WriteLine("Dairenin Alanı.......:" + alan.ToString("F2"));
        }
    }
}
