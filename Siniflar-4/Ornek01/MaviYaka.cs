using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class MaviYaka:Personel
    {

        string vardiya;

        public string Vardiya { get { return vardiya; } }
        
        public MaviYaka(string name,string surname,int identity,string department,decimal salary,string shift) : base(name, surname, identity, department, salary)
        {
          
            this.vardiya = shift;
            
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("Adı Soyadı.......: " + AdiSoyadi);
            Console.WriteLine("SicilNo..........: " + SicilNo);
            Console.WriteLine("Departmanı.......: " + Departman);
            Console.WriteLine("Vardiyası........: " + Vardiya);  
        }
    }
}
