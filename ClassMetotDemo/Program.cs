using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = "1111111111";
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Ali";
            musteri1.Telefon = "0537777777";
            musteri1.mail = "aaa@aaa.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = "22222222";
            musteri2.Ad = "Veli";
            musteri2.Soyad = "Veli";
            musteri2.Telefon = "0537777777";
            musteri2.mail = "aaa@aaa.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNo = "33333333";
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Ahmet";
            musteri3.Telefon = "0537777777";
            musteri3.mail = "aaa@aaa.com";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------------------");

            musteriManager.Listele(musteriler);
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            musteriManager.Sil(musteri3);
        }
    }
}
