using System;
using System.Text;

namespace PersonelOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Isci w1 = new Isci("İsmail", "Karaman", 10001, "Gündüz", "Bakım Onarım","Teknisyen");
            
            //w1.BilgileriGoster();
            //w1.MesaiHesapla();
            Usta u1 = new Usta();
            u1.Adi = "Mehmet";
            u1.Soyadi = "Güneş";
            u1.SicilNo = 15001;
            u1.Vardiya = "Gündüz";
            u1.Departman = "Montaj";
          
            u1.BilgileriGoster();
            u1.Adi = "Ahmet";
            Console.WriteLine();
            u1.BilgileriGoster();
            u1.MesaiHesapla();
            Console.ReadKey();
            
        }
    }

}
