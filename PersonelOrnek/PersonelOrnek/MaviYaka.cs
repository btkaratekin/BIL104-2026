using System;

namespace PersonelOrnek
{
    internal abstract class MaviYaka : Personel
    {
        protected string vardiya;
        protected decimal katsayi = 1;

        public MaviYaka()
        {

        }
        public MaviYaka(string name, string surname, int identity, string shift) : base(name, surname, identity)
        {
            this.adi = name;
            this.soyadi = surname;
            this.sicilno = identity;
            this.vardiya = shift.ToUpper();
            this.maas = 50000M;
        }
        public void MaasHesapla()
        {
            maas = maas * katsayi;
        }

        public void VardiyaDegistir()
        {
            if (vardiya == "GECE")
            {
                vardiya = "GÜNDÜZ";
            }
            else
            {
                vardiya = "GECE";
            }
            Console.WriteLine("Güncel Vardiyanız...: " + vardiya);
        }
    }
}
