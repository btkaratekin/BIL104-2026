using System;

namespace Ornek01 //Yapıcı ve Yıkıcı Metodlar
{
    public class BankaHesabi
    {
        string adi;
        string soyadi;
        int hesapno;
        decimal bakiye = 0;

        public string AdiSoyadi
        {
            get { return adi + " " + soyadi; }
            set
            {
                adi = value.Split(' ')[0];
                soyadi = value.Split(' ')[1];
            }
        }
        public int HesapNo { get { return hesapno; } set { hesapno = value; } }
        public  decimal Bakiye { get { return bakiye; } }


        public BankaHesabi()
        {

        }

        public BankaHesabi(string name, string surname, int accNumber, decimal balance)
        {
            this.adi = name;
            this.soyadi = surname;
            this.hesapno = accNumber;
            this.bakiye = balance;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Hesap Bilgileri");
            Console.WriteLine("Hesap No.........: "+hesapno);
            Console.WriteLine("Adı Soyadı.......: " + adi+" "+soyadi);
            Console.WriteLine("Bakiye...........: " + bakiye.ToString("C"));
            Console.WriteLine();
        }

        public void BakiyeGoster()
        {
            Console.WriteLine("Bakiye Bilgileri");
            Console.WriteLine("Kalan Bakiye...:"+bakiye.ToString("C"));
        }
    }

}
