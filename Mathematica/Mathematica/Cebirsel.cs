using System;

namespace Mathematica
{
    public class Cebirsel : CebirBase
    {
        public override double AortHesapla(double[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            double Aort = toplam / sayilar.Length;
            return Aort;
        }

        public override bool AsalKontrol(int sayi)
        {
            bool Asal = true;
            for (int i = 2; i < sayi; i++)
            {
                if ((sayi % i) == 0)
                {
                    Asal = false;
                    break;
                }
            }
            return Asal;

        }

        public override int EbobHesapla(int sayi1, int sayi2)
        {
            int kucuksayi = sayi1 < sayi2 ? sayi1 : sayi2;
            int ebob = 1;
            for (int i = 1; i <= kucuksayi; i++)
            {
                if (((sayi1 % i) == 0) && ((sayi2 % i) == 0))
                {
                    ebob = i;
                }
            }
            return ebob;

        }

        public override int EkokHesapla(int sayi1, int sayi2)
        {
            int buyuksayi = sayi1 > sayi2 ? sayi1 : sayi2;
            int ekok = buyuksayi;
            for (int i = buyuksayi; i < (sayi1 * sayi2); i++)
            {
                if (((i % sayi1) == 0) && ((i % sayi2) == 0))
                {
                    ekok = i;
                    break;
                }
            }
            return ekok;
        }

        public override ulong FaktoriyelHesapla(uint sayi)
        {
            ulong Faktoriyel = 1;
            for (uint i = 1; i <= sayi; i++)
            {
                Faktoriyel = Faktoriyel * i;
            }
            return Faktoriyel;
        }

        public override double GortHesapla(double[] sayilar)
        {
            double carpim = 1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                carpim = carpim * sayilar[i];
            }
            return Math.Pow(carpim, 1 / Convert.ToDouble(sayilar.Length));
        }

        public override bool TekCift(int sayi)
        {
            if ((sayi % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
