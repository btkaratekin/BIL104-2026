using System;

namespace Ornek02
{
    public class Kopek : Hayvan
    {
        public Kopek(string adi) : base(adi)
        {
        }

        public override void SesCikar()
        {
            base.SesCikar();
            Console.WriteLine("Hav Hav!");
        }
    }
}
