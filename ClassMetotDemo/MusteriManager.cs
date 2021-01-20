using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            
            Console.WriteLine("{0} nolu Id'li {1} {2} sisteme eklenmiştir",musteri.Id,musteri.Ad,musteri.Soyad);

        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşterilerin listesi");

            foreach (var mus in musteri)
            {
                Console.WriteLine("Müşteri ID: {0}",mus.Id);
                Console.WriteLine("Müşteri TC no: {0}",mus.TcNo);
                Console.WriteLine("Müşteri Adı,Soyadı: {0} {1}",mus.Ad,mus.Soyad);
                Console.WriteLine("Müşteri Telefon: {0}", mus.Telefon);
                Console.WriteLine("Müşteri e-mail adresi: {0}",mus.mail);
                Console.WriteLine("********************************");

            }

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} nolu Id'li {1} {2} sistemden silinmiştir.", musteri.Id, musteri.Ad, musteri.Soyad);

        }
    }
}
