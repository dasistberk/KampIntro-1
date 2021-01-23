using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Berk";
            musteri1.Soyadi = "Abay";
            musteri1.TcNo = "1245684";

            TüzelMüsteri musteri2 = new TüzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "143453";
            musteri2.SirketAdi = "Abay software";
            musteri2.VergiNo = "35245834";

            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TüzelMüsteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
