using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    public class AkademikPersonel:IArastirmaGorevlisi,IOgretimGorevlisi,IOgretimUyesi
    {
        string adi;
        string soyadi;
        string unvan;

        public AkademikPersonel(string name,string surname,string title)
        {
            adi=name;
            soyadi=surname;
            unvan=title;
        }

        public void ArastirmaYap(string konu)
        {
            Console.WriteLine(konu + " Konusu Üzerinde Araştırma Yapılıyor.");
        }

        public void BilgilendirmeYap(int ogrno)
        {
            Console.WriteLine(ogrno + " Numaralı Öğrenci, Ders Kaydı Hakkında Bilgilendirildi.");
        }

        public void DersAnlat(string ders)
        {
            Console.WriteLine(ders + " Dersi Anlatılıyor.");
        }

        public void DersKaydiYap(int ogrno)
        {
            Console.WriteLine(ogrno + " Numaralı Öğrencinin Ders Kaydı Onaylandı.");
        }

        public void MakaleIncele(string makale)
        {
            Console.WriteLine(makale + " Araştırmacı Tarafından İnceleniyor.");
        }

        public void MakaleYaz(string makale)
        {
           
        }

        public void SeminerDuzenle(string adi, string tarih)
        {
            
        }

        public void SinavYap(string ders)
        {
            
        }

        public void TezYaz(string konu)
        {
           
        }

        public void TezYurut(string tez)
        {
           
        }

        public void Yonet(string birim)
        {
            
        }
    }
}
