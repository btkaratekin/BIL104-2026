using System;

namespace Ornek03
{
    internal abstract class Sekil
    {
        protected int taban;
        protected int yukseklik;

        public virtual void CevreHesapla()
        {
            Console.Write("Çevresi....:");
        }
        public virtual void AlanHesapla()
        {
            Console.Write("Alanı......:");
        }
    }
}
