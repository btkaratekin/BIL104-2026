using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Kullanıcıdan bir metin alarak bu metindeki harfleri rastgele renklerde ekrana yazdıran bir metot yazınız. */
        static void Main(string[] args)
        {
            EkranaYaz();
            Console.ReadKey();
        }
        static void EkranaYaz()
        {
            Console.Write("Bir Metin Girin....:");
            string metin = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - metin.Length, Console.WindowHeight / 2);
            // Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < metin.Length; i++)
            {
                Console.ForegroundColor = RastgeleRenkVer();
                if (i == metin.Length - 1)
                {
                    Console.Write(metin[i]);
                }
                else
                {
                    Console.Write(metin[i] + " ");
                }
            }
        }
        static ConsoleColor RastgeleRenkVer()
        {
            Random rnd = new Random();

            int sayi = rnd.Next(5) + 1;
            Thread.Sleep(1);
            if (sayi == 1)
            {
                return ConsoleColor.Red;
            }
            else if (sayi == 2)
            {
                return ConsoleColor.Yellow;
            }
            else if (sayi == 3)
            {
                return ConsoleColor.White;
            }
            else if (sayi == 4)
            {
                return ConsoleColor.Blue;
            }
            else
            {
                return ConsoleColor.Green;
            }
        }
    }
}
