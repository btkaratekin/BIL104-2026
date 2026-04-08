using System;

namespace Ornek02
{
    public class Kedi : Hayvan
    {
        public Kedi(string adi) : base(adi)
        {

        }
        public override void SesCikar()
        {
            base.SesCikar();
            Console.WriteLine("Miyav!");
        }
    }
}
