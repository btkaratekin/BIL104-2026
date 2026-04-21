using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Motorsiklet : Tasit
    {
        public Motorsiklet(string marka, string model) : base(marka, model)
        {
            Tur = "Yarış Motorsikleti";
        }

        public override void Calistir()
        {
            Console.WriteLine("Kontak Çevrildi. Motorsiklet Çalışıyor.");
        }
        public override void BilgileriGoster()
        {
            Console.WriteLine("Motorsiklet Bilgileri");
            Console.WriteLine("Markası..........:" + Marka);
            Console.WriteLine("Modeli...........:" + Model);
            Console.WriteLine("Türü.............:" + Tur);
        }
        public override void HareketEt()
        {
            VitesDegistir(true);
            Console.WriteLine("Motorsiklet Hareket Halinde.");
            Hiz = Hiz + 20;
            Console.WriteLine("Güncel Hız....:" + Hiz);
        }

        public override void Hizlan()
        {
            Console.WriteLine("Motorsiklet Hızlanıyor. Dikkatli Olun.");
            Hiz = Hiz + 25;
            Console.WriteLine("Güncel Hız...:" + Hiz);
        }

        public override void VitesDegistir(bool durum)
        {
            if (durum == true)
            {
                vites++;
            }
            else
            {
                vites--;
            }
            Console.WriteLine("Güncel Vites...:" + vites);
            if (vites == 0)
            {
                Console.WriteLine("Motorsiklet Şuan Boşta.");
            }
        }

        public override void Yavasla()
        {
            Console.WriteLine("Ayak Frenine Basıldı. Motorsiklet Yavaşlıyor...");
            FrenYap();
        }

        void FrenYap()
        {
            if (Hiz > 0)
            {
                Hiz = Hiz - 20;
                if (Hiz<0)
                {
                    Hiz = 0;
                }
            }
            else
            {
               
                Console.WriteLine("Motorsiklet Duraklatıldı.");
            }
            Console.WriteLine("Güncel Hız...:" + Hiz);
        }
    }
}
