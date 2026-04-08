using System;

namespace PersonelOrnek
{
    internal sealed class Muhendis : BeyazYaka
    {
        string unvan;
        string projeAdi;
        decimal projekatki=0;
        public Muhendis()
        {
        }

        public Muhendis(string name, string surname, int identity, string department) : base(name, surname, identity, department)
        {
            this.unvan = "Mühendis";
           
            MaasHesapla();
        }

        public void DepartmanDegistir(string department)
        {
            this.departman=department;
            Console.WriteLine("Mühendisin Departmanı Değişti.");
            MaasHesapla();
        }

        public override void BilgileriGoster()
        {
            base.BilgileriGoster();        
            Console.WriteLine("Statü.................: Beyaz Yaka");
            Console.WriteLine("Ünvanı................: " + unvan);
            Console.WriteLine("Departmanı............: " + departman);
            Console.WriteLine("Çalıştığı Proje.......: " + projeAdi);
          
        }

        void MaasHesapla()
        {
            this.maas = (tabanmaas *1.5M)+ PrimHesapla(departman)+projekatki;
        }

        public void MaasGoster()
        {
            Console.WriteLine("Güncel Maaş...........:" + maas.ToString("C"));
        }

        public void ProjeOlustur(string projectname)
        {
            this.projeAdi= projectname;
            Console.WriteLine(projeAdi + " Adında Bir Proje Oluşturuldu.");
            this.projekatki = 10000M;
            MaasHesapla();
        }
        public void ProjeOlustur(string projectname,decimal balance)
        {
            this.projeAdi= projectname;
            Console.WriteLine(projeAdi + " Adında Bir Proje Oluşturuldu.");
            this.projekatki= balance * 0.05M;
            MaasHesapla();
        }
    }
}
