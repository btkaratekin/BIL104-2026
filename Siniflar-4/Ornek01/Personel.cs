using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Personel
    {

        protected string adi;
        protected string soyadi;
        protected int sicilno;
        protected string departman;
        protected decimal maas;

        public string AdiSoyadi { get { return adi + " " + soyadi; } }
        public int SicilNo { get { return sicilno; } }
        public string Departman { get { return departman; } }

        public Personel()
        {

        }
        public Personel(string name, string surname, int identity, string department, decimal salary)
        {
            this.adi = name;
            this.soyadi = surname;
            this.sicilno = identity;
            this.departman = department;
            this.maas = salary;
        }
        //public void BilgileriGoster()
        //{
        //    Console.WriteLine("Personel Bilgileri");
        //    Console.WriteLine("Adı Soyadı.......: " + AdiSoyadi);
        //    Console.WriteLine("SicilNo..........: " + SicilNo);
        //    Console.WriteLine("Departmanı.......: " + Departman);
        //}
    }
}
