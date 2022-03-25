using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Don't repeat yourself!

            Product product1 = new Product();

            product1.Name = "Computer";
            product1.Price = 15000;
            product1.Comment = "Gaming Notebook";

            Product product2 = new Product();

            product2.Name = "Phone";
            product2.Price = 20000;
            product2.Comment = "Iphone 13 Pro Max";
            
            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Comment);
                Console.WriteLine("--------------------");
            }


            Console.WriteLine("------------Methods-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Computer", "Lenovo", 5700);
            sepetManager.Add2("Phone", "Huawei", 5700);
            sepetManager.Add2("Airpods", "Apple", 5700);

        }
    }
}
