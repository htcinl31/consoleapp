using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriadi = "Hatice";
            musteri1.musterisoyadi="İnal";
            musteri1.musteriId = 1;

            Musteri musteri2 = new Musteri();
            musteri2.musteriadi = "Hacer";
            musteri2.musterisoyadi = "Kahriman";
            musteri2.musteriId = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriadi);
                Console.WriteLine(musteri.musterisoyadi);
                Console.WriteLine(musteri.musteriId);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1.musteriadi,musteri1.musterisoyadi,musteri1.musteriId);
            musteriManager.Ekle(musteri2.musteriadi,musteri2.musterisoyadi,musteri2.musteriId);
            




        }
    }
}
