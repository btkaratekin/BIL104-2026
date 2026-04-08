using System;

namespace Ornek02
{
    public abstract class Hayvan
    {
        protected string adi;

        public Hayvan(string adi)
        {
            this.adi = adi;
        }
        public virtual void SesCikar()
        {
            Console.Write("Ben Bir " + adi + " yim. Ve Çıkardığım Ses ");
        }
    }
}
