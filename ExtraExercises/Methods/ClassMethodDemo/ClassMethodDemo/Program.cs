using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); //we create and define space for customer1

            customer1.Id = 15;
            customer1.Name = "Onur";
            customer1.Surname = "Coşkun";
            customer1.Number = "5304624788";
            customer1.Age = 29;

            Customer customer2 = new Customer();

            customer2.Id = 11;
            customer2.Name = "Adil";
            customer2.Surname = "Topal";
            customer2.Number = "5304624788";
            customer2.Age = 32;

            Customer customer3 = new Customer();

            customer3.Id = 7;
            customer3.Name = "Poyraz";
            customer3.Surname = "Karayel";
            customer3.Number = "5304624788";
            customer3.Age = 28;

            Customer customer4 = new Customer();

            customer4.Id = 7;
            customer4.Name = "Poyraz";
            customer4.Surname = "Karayel";
            customer4.Number = "5304624788";
            customer4.Age = 28;

            Customer[] customers = new Customer[] { customer1, customer2 , customer3, customer4};
            // Here we apply both creating array from objects and converting to list.
            List<Customer> customerlist = new List<Customer>(customers);
            customerlist.Add(new Customer {Id = 1, Name="Ümit", Surname="Şahin", Age = 30, Number="5304624788" }); //Adding with the List method
            Customer customerApo= new Customer { Name= "Halit", Surname="Bursa", Age=26, Id=2, Number="5304624788"}; //Adding to the list by defining a variable
            customerlist.Add(customerApo);
            CustomerManager customermanager = new CustomerManager();

            customermanager.Listing(customerlist); 
            
            customermanager.Add(customerApo);

            customermanager.Delete(customer3);

                    
        }
    }
}
