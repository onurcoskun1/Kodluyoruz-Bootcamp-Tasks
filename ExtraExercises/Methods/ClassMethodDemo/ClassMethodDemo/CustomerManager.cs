using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager // Add/delete and list operations are executed in this class
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Welcome {customer.Name} {customer.Surname}");

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"Take care {customer.Name} {customer.Surname}");
        }

        public void Listing(List<Customer> customers)
        {
            foreach (Customer someone in customers)
            {
                Console.WriteLine(someone.Id);
                Console.WriteLine(someone.Name);
                Console.WriteLine(someone.Surname);
                Console.WriteLine(someone.Number);
                Console.WriteLine(someone.Age);

                Console.WriteLine("------------------------------------------------");
            }
        }
    }
}
