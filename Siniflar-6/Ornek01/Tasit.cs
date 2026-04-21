using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    public abstract class Tasit
    {
        protected string Marka;
        protected string Model;
        protected string Tur;
        protected int Hiz;
        protected int vites;

        public Tasit(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }
        public abstract void BilgileriGoster();
        public abstract void Calistir();
        public abstract void Hizlan();
        public abstract void HareketEt();
        public abstract void Yavasla();
        public abstract void VitesDegistir(bool durum);
       
    }
}
