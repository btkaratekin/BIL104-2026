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
            Bisiklet b1 = new Bisiklet("Bianchi", "Shark");
            Motorsiklet m1 = new Motorsiklet("Yamaha", "Hyper");

            b1.BilgileriGoster();
            b1.Calistir();
            b1.HareketEt();
            b1.Hizlan();
            b1.VitesDegistir(true);
            Console.WriteLine();
            m1.BilgileriGoster();
            m1.Calistir();
            m1.HareketEt();
            m1.Hizlan();
            m1.VitesDegistir(true);
            m1.Hizlan();
            m1.Yavasla();
            m1.VitesDegistir(false);
            m1.Yavasla();
            m1.Yavasla();
            m1.Yavasla();
            m1.Yavasla();

            Console.ReadKey();

        }
    }
}
