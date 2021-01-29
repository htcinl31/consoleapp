using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself - kendini tekrar etme
            //değer tutucu,alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }

            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış oku");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }





            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
