using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class BeyazYaka:Personel
    {
        string unvan;
        
        public string Unvan { get { return unvan; } }
        
        public BeyazYaka(string name,string surname,int identity,string department,decimal salary,string title):base(name,surname,identity,department,salary)
        {
            this.unvan = title;
        }
        public void IseBasla()
        {
            Console.WriteLine(this.AdiSoyadi + " Saat 08:30 da Çalışmaya Başladı.");
        }

        public void BilgileriGosterB()
        {
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("Adı Soyadı.......: " + AdiSoyadi);
            Console.WriteLine("SicilNo..........: " + SicilNo);
            Console.WriteLine("Departmanı.......: " + Departman);
            Console.WriteLine("Unvanı........: " + Unvan);
        }
    }
}
