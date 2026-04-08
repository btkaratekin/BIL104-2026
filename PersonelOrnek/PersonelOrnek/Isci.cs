using System;

namespace PersonelOrnek
{
    internal sealed class Isci:MaviYaka
    {
        string unvan;
        string departman;
        decimal mesaiucreti = 150;
        decimal gunduzmesaisaati;
        decimal gecemesaisaati;

        public Isci(string name,string surname,int identity,string shift,string department,string title):base(name,surname,identity,shift)
        {
            this.departman = department;
            this.unvan = title;
            katsayi = KatsayiHesapla(unvan);
            MaasHesapla();
        }

        decimal KatsayiHesapla(string title)
        {
            if (title == "Operatör")
            {
                return katsayi * 1.25M;
            }
            else if (title == "Teknisyen")
            {
                return katsayi * 1.35M;
            }
            else if (title == "Tekniker")
            {
                return katsayi * 1.5M;
            }
            else
            {
                return katsayi = 1;
            }
        }
        public void MesaiHesapla()
        {
            Console.Write("Gündüz Yapılan Toplam Mesai Saati.: ");
            gunduzmesaisaati = decimal.Parse(Console.ReadLine());
            Console.Write("Gece Yapılan Toplam Mesai Saati...: ");
            gecemesaisaati=decimal.Parse(Console.ReadLine());


            decimal gunduzucrettoplam = gunduzmesaisaati * mesaiucreti;
            decimal geceucrettoplam = gecemesaisaati * (mesaiucreti + 50M);
            Console.WriteLine("Gündüz Mesai Ücreti...:" + gunduzucrettoplam.ToString("C"));
            Console.WriteLine("Gece Mesai Ücreti.....: " + geceucrettoplam.ToString("C"));

            Console.WriteLine("Alınacak Toplam Maas..:" + (maas + gunduzucrettoplam + geceucrettoplam).ToString("C"));

            

        }

        public override void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Statüsü..........: Mavi Yakalı Personel");
            Console.WriteLine("Departmanı.......: " + departman);
            Console.WriteLine("Ünvanı...........: " + unvan);
            Console.WriteLine("Çalıştığı Vardiya: " + vardiya);
            Console.WriteLine("Maaşı............: " + maas.ToString("C"));

        }
    }
}
