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
      Console.OutputEncoding = Encoding.UTF8;
      HesapBilgi hesap1 = new HesapBilgi();
      hesap1.HesapOlustur("Ahmet", "YILMAZ", 36526980);
      hesap1.HesapGoruntule();
      hesap1.ParaYatir(3000);
      Console.WriteLine("Güncel Hesap Bakiyesi..: " + hesap1.Bakiye);
      Console.WriteLine();
      hesap1.ParaCek(2500);
      Console.WriteLine();
      Console.WriteLine("Güncel Hesap Bakiyesi..: " + hesap1.Bakiye);
      Console.WriteLine();
      Console.ReadKey();
    }
  }
}
