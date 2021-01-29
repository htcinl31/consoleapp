using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Engin");
<<<<<<< HEAD
            Console.WriteLine(isimler.Length);

            isimler.Add("Deren");
            Console.WriteLine(isimler.Length  );

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

=======
            Console.WriteLine();
>>>>>>> c2939dda9cfbe7243208837b20a42a83fe3b01b8
        }
    }
}
