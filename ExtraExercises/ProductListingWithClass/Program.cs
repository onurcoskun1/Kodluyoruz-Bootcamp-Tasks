using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductListingWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //In this field, we call the objects from the class we created to define the products and enter the information.

            Product product1 = new Product();
            product1.productName = "Nokia 3310";
            product1.productPrice = 150;
            product1.productType = "Telefon";
            product1.productProp = "Tuşlu, kızılötesi ve radio var";

            Product product2 = new Product();
            product2.productName = "Iphone 13 Pro Max";
            product2.productPrice = 20000;
            product2.productType = "Akıllı Telefon";
            product2.productProp = "Dokunmatik, 4K çekim, Bluetooth vs.";

            Product product3 = new Product();
            product3.productName = "Monster Abra v17.2";
            product3.productPrice = 15530;
            product3.productType = "Bilgisayar";
            product3.productProp = "16 GB RAM, 500 GB SSD, 3050Ti Ekran Kartı vs.";

            Product product4 = new Product();
            product4.productName = "Huawei Freebuds 4";
            product4.productPrice = 2200;
            product4.productType = "Kulaklık";
            product4.productProp = "Bluetooth 5.0, ANC, Hızlı şarj vs.";

            Product[] products = new Product[] {product1, product2, product3, product4};  // We create an array from the variables of the objects we created.

            foreach (var product in products)  //This is how we can list the products in the array we created using foreach.
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productType);
                Console.WriteLine(product.productProp);
                Console.WriteLine(product.productPrice);
                Console.WriteLine("-------------------------------------");
            }

            for (int i = 0; i < products.Length; i++)  //If we want to use a for loop..
            {
                Console.WriteLine(products[i].productName);
                Console.WriteLine(products[i].productType);
                Console.WriteLine(products[i].productProp);
                Console.WriteLine(products[i].productPrice);
                Console.WriteLine("-------------------------------------");
            }

            int j = 0;
            while (j < products.Length)      //If we want to use a while loop we can do it like this.
            {
                Console.WriteLine(products[j].productName);
                Console.WriteLine(products[j].productType);
                Console.WriteLine(products[j].productProp);
                Console.WriteLine(products[j].productPrice);
                Console.WriteLine("-------------------------------------");
                j++;    
            }



        }

        class Product  //We create a class to define the products more easily.
        {
            public string productName { get; set; }   //We objectified the product name.

            public int productPrice { get; set; } //and the product price   

            public string productType { get; set; } // and type of product

            public string productProp { get; set; }// and last one, product property
        }

    }
}
