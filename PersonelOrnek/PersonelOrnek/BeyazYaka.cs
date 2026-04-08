namespace PersonelOrnek
{
    internal abstract class BeyazYaka : Personel
    {
        protected string departman;
        protected decimal tabanmaas;
        decimal prim = 0;

        protected BeyazYaka()
        {
        }

        protected BeyazYaka(string name, string surname, int identity,string department) : base(name, surname, identity)
        {
            this.departman = department;
            this.tabanmaas = 70000M;
            this.prim = PrimHesapla(departman);
           
        }
        protected decimal PrimHesapla(string department)
        {
            if (department=="ARGE")
            {
                prim = 15000;
            }
            else if (department=="OPERASYON")
            {
                prim = 25000;
            }
            else
            {
                prim = 5000;
            }
            return prim;
        }

        
    }
}
