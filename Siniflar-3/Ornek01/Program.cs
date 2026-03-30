using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01 //Yapıcı ve Yıkıcı Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            BankaHesabi m1 = new BankaHesabi();
            m1.AdiSoyadi = "İsmail KARAMAN";
            m1.HesapNo = 256632650;
            m1.BilgileriGoster();
            Console.WriteLine("Kalan Bakiye....: " + m1.Bakiye.ToString("C"));
            Console.WriteLine();
            BankaHesabi m2 = new BankaHesabi("Eylül", "GENÇ", 1452125230, 500M);
            m2.BilgileriGoster();
            Console.ReadKey();
        }
    }

}
