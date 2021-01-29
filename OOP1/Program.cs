using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu şekil de ürün tanımlanabilir

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // bu şekilde de ürün tanımlanabilir

            Product product2 = new Product{Id=2,CategoryId=5,UnitsInStock=5,
                ProductName="Kalem",UnitPrice=35};


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

<<<<<<< HEAD
            
            
            
            
=======
>>>>>>> c2939dda9cfbe7243208837b20a42a83fe3b01b8
            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2);


        }
    }
    
    
    
    //yukarıda tanımladığımız ürünler aslında böyle yazılmaz.bunları angular uygulaması ile kullanıcı girer.
    // öğrenmek açısından bizler ürün tanımlıyoruz.
}
