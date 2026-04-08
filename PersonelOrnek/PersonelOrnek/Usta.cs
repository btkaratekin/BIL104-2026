using System;

namespace PersonelOrnek
{
    internal sealed class Usta:MaviYaka
    {
        string departman;
        decimal gunduzmesaiücreti = 750;
        decimal gecemesaiücreti = 1000;

        public string Adi { get { return adi; } set{ adi = value; } }
        public string  Soyadi { get { return soyadi.ToUpper(); } set { soyadi = value; } }
        public int SicilNo { get { return sicilno; } set { sicilno = value; } }
        public string Departman { get { return departman; } set { departman = value; } }
        public string Vardiya { get { return vardiya; } set { vardiya = value; } }
        

        public Usta()
        {
            KatsayiHesapla();
            maas = 50000M;
            MaasHesapla();
            
        }
        public Usta(string name, string surname, int identity, string shift) : base(name, surname, identity, shift)
        {
            
            KatsayiHesapla();
            MaasHesapla();
        }
        void KatsayiHesapla()
        {
            katsayi = 1.8M;
        }
        public void BilgileriGoster()
        {
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("Sicil No.........: " + sicilno);
            Console.WriteLine("Adı Soyadı.......: " + adi + " " + soyadi);
            Console.WriteLine("Statüsü..........: Mavi Yakalı Personel");
            Console.WriteLine("Departmanı.......: " + departman);
            Console.WriteLine("Ünvanı...........: Usta Personel");
            Console.WriteLine("Çalıştığı Vardiya: " + vardiya);
            Console.WriteLine("Maaşı............: " + maas.ToString("C"));

        }

        public void MesaiHesapla()
        {
            Console.Write("Gündüz Katıldığınız Mesai Adeti...:");
            decimal gunduzmesai = decimal.Parse(Console.ReadLine());
            Console.Write("Gece Katıldığınız Mesai Adeti.....:");
            decimal gecemesai = decimal.Parse(Console.ReadLine());
            decimal toplammesaiücreti = (gunduzmesai * gunduzmesaiücreti) + (gecemesai * gecemesaiücreti);
            Console.WriteLine("Alacağınız Gündüz Mesai Ücreti:" + (gunduzmesai * gunduzmesaiücreti).ToString("C"));
            Console.WriteLine("Alacağınız Gece Mesai Ücreti..:" + (gecemesai * gecemesaiücreti).ToString("C"));
            Console.WriteLine("Alacağınız Toplam Mesai Ücreti.:" + toplammesaiücreti.ToString("C"));

            Console.WriteLine("Bu Ay Alacağınız Toplam Maaş...:" + (maas + toplammesaiücreti).ToString("C"));

        }
    }
}
