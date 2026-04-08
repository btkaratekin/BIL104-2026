using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi cat = new Kedi("Kedi");
            cat.SesCikar();
            Console.WriteLine();
            Kopek dog = new Kopek("Köpek");
            dog.SesCikar();
            Console.WriteLine();
            Kus bird = new Kus("Kus");
            bird.SesCikar();
            Console.ReadKey();
        }
    }
}
