using System;

namespace KitaplarOrnek
{
    internal class Kitap
    {
        public string Adi { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Kategori { get; set; }
        public int BasimYili { get; set; }
        public decimal Fiyat { get; set; }

        public Kitap(string adi, string yazar, string yayinevi, int sayfasayisi, string kategori, int basimyili, decimal fiyat)
        {
            this.Adi = adi;
            this.Yazar = yazar;
            this.YayinEvi = yayinevi;
            this.SayfaSayisi = sayfasayisi;
            this.Kategori = kategori;
            this.BasimYili = basimyili;
            this.Fiyat = fiyat;
        }

        public void Yazdir()
        {
            Console.WriteLine($"{Adi,-35}  {Yazar,-25}  {YayinEvi,-30}  {SayfaSayisi,4}  {Kategori,-15}  {BasimYili,4}  {Fiyat.ToString("C2"),6}");
        }
    }
}
