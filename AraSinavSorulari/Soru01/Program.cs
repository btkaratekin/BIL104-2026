using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru01
{
    public sealed class Kitap
    {
        string adi;
        string yazari;
        int sayfasayisi;
        decimal fiyat;

        public Kitap(string name,string author,int pagecount,decimal price)
        {
            this.adi = name;
            this.yazari = author;
            this.sayfasayisi = pagecount;
            this.fiyat = price;
        }

        public void Goster()
        {
            Console.WriteLine("Kitabın Adı....:"+adi + "\nYazarı........:" + yazari + "\nSayfa Sayısı...:" + sayfasayisi);
        }

        public void Goster(decimal kdvoran)
        {
            decimal kdvlifiyat = fiyat + (fiyat * kdvoran / 100);
            Console.WriteLine("Kitabın Adı....:" + adi + "\nFiyatı........:" + fiyat.ToString("C") + "\nKdv Dahil Fiyatı...:" + kdvlifiyat.ToString("C"));
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Kitap ktp = new Kitap("Suç ve Ceza", "Dostoyevski", 750, 560);
            ktp.Goster();
            Console.WriteLine();
            ktp.Goster(18);
            Console.ReadKey();
        }
    }
}
