using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01 //KALITIM - (MİRAS)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel("Ahmet", "KAYMAZ", 25638, "İnsan Kaynakları", 60000M);
            p1.BilgileriGoster();

            Console.WriteLine();

            MaviYaka m1 = new MaviYaka("İlker", "GÜNEŞ", 25698, "Atölye", 45000M, "Gece");
            m1.BilgileriGoster();
            m1.BilgileriGosterM();

            Console.WriteLine();

            BeyazYaka b1 = new BeyazYaka("Esra", "DÜNDAR", 11520, "Yazılım", 100000, "Veritabanı Tasarımcısı");
            Console.WriteLine(b1.AdiSoyadi);
            b1.BilgileriGoster();
            Console.ReadKey();
        }
    }
}
