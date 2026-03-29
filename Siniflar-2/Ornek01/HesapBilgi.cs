using System;

namespace Ornek01
{
  class HesapBilgi
  {
    string adi;
    string soyadi;
    int hesapno;
    decimal bakiye = 0;

    public string Bakiye { get { return bakiye.ToString("C"); } }


    public string Adi
    {
      get
      {
        if (string.IsNullOrEmpty(adi))
        {
          Console.WriteLine("İsim Alanı Atanmamış.");
          return null;
        }
        else
        {
          return adi;
        }
      }
      set
      {
        adi = value;
      }
    }
    public string Soyadi
    {
      get
      {
        if (string.IsNullOrEmpty(soyadi))
        {
          Console.WriteLine("İsim Alanı Atanmamış.");
          return null;
        }
        else
        {
          return soyadi;
        }
      }
      set
      {
        soyadi = value;
      }
    }

    public string AdiSoyadi { get { return adi + " " + soyadi; } }

    internal void HesapOlustur(string gelenadi, string gelensoyadi, int gelenhesapno)
    {
      adi = gelenadi;
      soyadi = gelensoyadi;
      hesapno = gelenhesapno;
    }
    internal void HesapGoruntule()
    {
      Console.WriteLine("Hesap Bilgileri");
      Console.WriteLine("Hesap No.......: " + hesapno);
      Console.WriteLine("Hesap Sahibi...: " + adi + " " + soyadi);
      Console.WriteLine("Güncel Bakiye..: " + bakiye.ToString("C"));
      Console.WriteLine();
    }

    internal void ParaYatir(decimal miktar)
    {
      if (miktar > 0)
      {
        bakiye += miktar;
        Console.Write("Hesaba Para Yatırma İşlemi Yapıldı.\nYatırılan Tutar..: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(miktar.ToString("C"));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Para Yatırma İşlemi 0 yada Negatif Olamaz..");
        Console.ForegroundColor = ConsoleColor.Gray;
      }


    }
    internal void ParaCek(decimal miktar)
    {
      if (bakiye < miktar)
      {
        Console.WriteLine("Yetersiz Bakiye. Lütfen Çekmek İstediğiniz Tutarı Kontrol Edin.");
      }
      else
      {
        if (miktar <= 0)

        {
          Console.WriteLine("Çekmek İstediğiz Tutar 0 dan Büyük Olmalıdır.");
        }
        else
        {
          bakiye -= miktar;
          Console.WriteLine("Hesaptan Para Çekme İşlemi Yapıldı.\nÇekilen Tutar.: " + miktar.ToString("C"));
        }
      }
    }
  }
}
