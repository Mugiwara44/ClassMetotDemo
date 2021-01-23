using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + musteri.SoyIsim + " isimli yeni müşteri eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + musteri.SoyIsim + " isimli müşteri silindi.");
        }
    }
}
