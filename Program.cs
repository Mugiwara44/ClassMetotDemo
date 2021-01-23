using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 004324;
            musteri1.Isim = "Ebru";
            musteri1.SoyIsim = "C**";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 000242;
            musteri2.Isim = "Mehmet";
            musteri2.SoyIsim = "Kes***";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0002524;
            musteri3.Isim = "Masal";
            musteri3.SoyIsim = "C**";

            Console.WriteLine("Müşteri Listesi: ");

            Musteri[] musteriler = new Musteri[] { musteri2, musteri3};
            foreach (var kisi in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + kisi.Id + " Müşteri İsmi: " + kisi.Isim + " " + kisi.SoyIsim);
            }

            Console.WriteLine("-------------------------"); 

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            Console.WriteLine("Müşteri Listesi: ");
            Musteri[] musteriler2 = new Musteri[] { musteri1, musteri3 };

            Console.WriteLine("-------------------------");

            foreach (var kisi in musteriler2)
            {
                Console.WriteLine("Müşteri Id: " + kisi.Id + " Müşteri İsmi: " + kisi.Isim + " " + kisi.SoyIsim);
            }

        }

    }
}
