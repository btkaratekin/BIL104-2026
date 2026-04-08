namespace PersonelOrnek
{
    internal abstract class Personel
    {
        protected int sicilno;
        protected string adi;
        protected string soyadi;
        protected decimal maas;

        public Personel()
        {

        }
        public Personel(string name, string surname, int identity)
        {
            this.adi = name;
            this.soyadi = surname;
            this.sicilno = identity;
        }
    }
}
