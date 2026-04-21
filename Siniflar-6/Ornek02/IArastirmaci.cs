namespace Ornek02
{
    public interface IArastirmaci
    {
        void ArastirmaYap(string konu);
        void TezYaz(string konu);
        void MakaleYaz(string makale);
        void MakaleIncele(string makale);
    }

    public interface IDanisman
    {
        void DersKaydiYap(int ogrno);
        void BilgilendirmeYap(int ogrno);
    }

    public interface IOkutman
    {
        void DersAnlat(string ders);
        void SinavYap(string ders);
    }
    public interface IOrganizator
    {
        void SeminerDuzenle(string adi, string tarih);
        void TezYurut(string tez);
        void Yonet(string birim);
    }

}
