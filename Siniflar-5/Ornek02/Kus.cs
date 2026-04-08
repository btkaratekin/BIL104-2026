using System;

namespace Ornek02
{
    public class Kus : Hayvan
    {
        public Kus(string adi) : base(adi)
        {
        }

        public override void SesCikar()
        {
            base.SesCikar();
            Console.WriteLine("Cik Cik!");
        }
    }
}
