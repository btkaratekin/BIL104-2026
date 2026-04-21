using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Bisiklet:Tasit
    {
        public Bisiklet(string marka,string model):base(marka,model)
        {
            Tur = "Dağ Bisikleti";  
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine("Bisiklet Bilgileri");
            Console.WriteLine("Markası..........:" + Marka);
            Console.WriteLine("Modeli...........:" + Model);
            Console.WriteLine("Türü.............:" + Tur);
        }

        public override void Calistir()
        {
            Console.WriteLine("Bisikleti Çalıştırmanız İçin Herhangi Bir İşlem Yapmanız Gerekmiyor.");
        }

        public override void HareketEt()
        {
            vites = 1;
            Console.WriteLine("Pedalları Çevirerek Hareketlenme Başlıyor.");
            Hiz = Hiz + 10;
            Console.WriteLine("Güncel Hız...:" + Hiz);
        }

        public override void Hizlan()
        {
            Console.WriteLine("Pedallar Hızlı Çevrilmeye Başlandı. Güncel Hız Artırılıyor...");
            Hiz=Hiz+10;
            Console.WriteLine("Güncel Hız...:" + Hiz);

        }

        public override void VitesDegistir(bool durum)
        {
            if (durum==true)
            {
                vites++;
                Console.WriteLine("Vites Artırıldı. Pedallama Zorlaştı..");
               
            }
            else
            {
                vites--;
                Console.WriteLine("Vites Düşürüldü. Pedallama Kolaylaştı");
            }
            Console.WriteLine("Güncel Vites...:" + vites);
        }

        public override void Yavasla()
        {
            if (Hiz<0)
            {
                Console.WriteLine("Bisiklet Durdu.");
            }
            else
            {
                Console.WriteLine("Bisiklet Yavaşlıyor. Lütfen Pedallamayı Bırakın");
                FrenYap();
            }
        }
        void FrenYap()
        {
            Console.WriteLine("Fren Maneti Sıkılıyor. Hızınız Düşüyor.");
            Hiz = Hiz - 5;
        }
    }
}
