using Hafta10_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AkademikPersonel a1 = new AkademikPersonel("İsmail", "Karaman", "Öğretim Görevlisi");
            IOgretimGorevlisi o1 = new AkademikPersonel("Halis", "Sert", "Öğretim Görevlisi");
            IOgretimUyesi r1 = new AkademikPersonel("Mehmet", "Güneş", "Doktor Öğretim Üyesi");

        }
    }
}
