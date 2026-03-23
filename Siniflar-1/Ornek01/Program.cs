using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sınıf_Adı Nesne_Adı = new Sınıf_Adı()
           
            Araba a1 = new Araba();
            a1.marka = "Hyundai";
            a1.model = "Elentra";
            a1.renk = "Beyaz";
            a1.motorhacmi = 1400;
            a1.uretimyili = 2022;
            a1.vitesturu = "Otomatik";
            a1.kasatipi = "Hatcback";

            Araba a2 = new Araba();

            a2.marka = "Mercedes";
            a2.model = "E200";
            a2.renk = "Siyah";
            a2.motorhacmi = 1600;
            a2.yakitturu = "Benzin";
            a1.BilgileriGoster();
            a1.Calistir('N', 0);
            a2.BilgileriGoster();
            Console.ReadKey();

        }
    }
    public class Araba
    {

        public string marka;
        internal string model;
        public string renk;
        public int motorhacmi = 0;
        public string yakitturu = "Dizel";
        public string vitesturu = "Manuel";
        public string kasatipi = "Sedan";
        public int uretimyili = -1;

        private char vites = 'N';
        private bool kontak = false;
        double yakitdegeri = 1;
        private int yas;

        internal void BilgileriGoster()
        {
            yas = 2026 - uretimyili;
            Console.WriteLine("Araç Bilgileri");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Marka........: " + marka);
            Console.WriteLine("Model........: " + model);
            Console.WriteLine("Renk.........: " + renk);
            if (uretimyili != -1)
            {
                Console.WriteLine("Üretim Yılı..: " + uretimyili);
                Console.WriteLine("Yaş..........: " + yas);
            }
            else
            {
                Console.WriteLine("Üretim Yılı..: Üretim Yılı Bilgisi Girilmedi.");
            }

            Console.WriteLine("Vites Türü...: " + vitesturu);
            Console.WriteLine("Kasa Tipi....: " + kasatipi);
            Console.WriteLine("Motor Hacmi..: " + motorhacmi);
            Console.WriteLine("Yakıt Türü...: " + yakitturu);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }
        internal void Calistir(char gelenvites, double gelenyakit)
        {
            vites = gelenvites;
            yakitdegeri = gelenyakit;
            if (KontakAc() == true)
            {
                if (yakitdegeri >= 2)
                {
                    Console.WriteLine("Araç Çalıştırıldı");

                }
                else
                {
                    Console.WriteLine("Araçta Yeterli Miktarda Yakıt Yok. Lütfen Araca Yakıt Eklemesi Yapın.");
                }
            }
        }
        void Durdur()
        {
            if (vites == 'N')
            {
                if (kontak == true)
                {
                    kontak = false;
                    Console.WriteLine("Araç Başarıyla Durduruldu");
                }
            }
            else
            {
                Console.WriteLine("Araç Viteste Olduğu İçin Durdurulamıyor. Lütfen Vitesi N Konumuna Alın.");
            }
        }
        bool KontakAc()
        {
            if (vites == 'N')
            {
                kontak = true;
            }
            else
            {
                Console.WriteLine("Kontak Açılamıyor. Lütfen Aracı Boş Vitese Alın");
                kontak = false;
            }
            return kontak;
        }
    }

}
