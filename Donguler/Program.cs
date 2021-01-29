using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım";
            string kurs2 = "programlama";
            string kurs3 = "java";

            //array-dizi

            string[] kurslar = new string[]
            {

                "yazılım","programlama","java","python"
            };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu--footer");




            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            } 
        }
    }
}
