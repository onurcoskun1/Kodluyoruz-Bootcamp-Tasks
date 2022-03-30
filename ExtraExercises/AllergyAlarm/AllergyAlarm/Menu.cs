using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllergyAlarm
{
    internal class Menu
    {
        int cost = 0;
        List<Bakery> bakeries = new List<Bakery>
            {
                new Bakery {Name = "Strawberry Pie" , Price= 50},
                new Bakery {Name = "Apple Pie", Price= 40 },
                new Bakery {Name = "Brownie", Price= 55},
                new Bakery {Name = "San Sebastian", Price= 70},
                new Bakery {Name = "Muffin", Price= 30}
            };

        List<Drinks> drinks = new List<Drinks>
            {
                new Drinks {Name = "Filter Coffee", Price= 20},
                new Drinks {Name = "Latte", Price= 22},
                new Drinks {Name = "Lemonade", Price=25},
                new Drinks {Name = "Coke", Price= 18},
                new Drinks {Name = "Water", Price= 10}
            };
        public void MainMenu()
        {
            
            Console.WriteLine("Welcome to C Bakery!");
            Console.WriteLine();
            Console.WriteLine("Would you like a menu? (Y/N): ");
            string menuAnswer = Console.ReadLine();
            switch (menuAnswer.ToUpper())
            {
                case "Y":
                    BakeryMenu();
                    break;
                case "N":
                    MainMenu();
                    break;
            }
        }

        public void BakeryMenu()
        {
            int i = 1;
            Console.WriteLine("-----Bakery Menu-----");
            foreach (var bakery in bakeries)
            {
                Console.WriteLine($"{i}. {bakery.Name} :   {bakery.Price}");;
                i++;
            }
            ChoiceBakery();
        }

        public void ChoiceBakery()
        {
            Console.WriteLine("Enter your order? (with digit): ");
            int choose1 = int.Parse(Console.ReadLine());
            string allergy = "";

            switch (choose1)
            {
                case 1:
                    Console.WriteLine("Are you allergic to strawberries? (Y/N)");
                    allergy = Console.ReadLine();
                    cost = bakeries[0].Price;
                    break;
                case 2:
                    Console.WriteLine("Are you allergic to apple? (Y/N)");
                    allergy = Console.ReadLine();
                    cost = bakeries[1].Price;
                    break;
                case 3:
                    Console.WriteLine("Are you allergic to chocolate? (Y/N)");
                    allergy = Console.ReadLine();
                    cost = bakeries[2].Price;
                    break;
                case 4:
                    Console.WriteLine("Are you allergic to milk? (Y/N)");
                    allergy = Console.ReadLine();
                    cost = bakeries[3].Price;
                    break;
                case 5:
                    Console.WriteLine("Are you allergic to peanut butter? (Y/N)");
                    allergy = Console.ReadLine();
                    cost = bakeries[4].Price;
                    break;

            }
            switch (allergy.ToUpper())
            {
                case "Y":
                    Console.WriteLine("You can't order it. Choose another bakery please!");
                    cost = 0;
                    BakeryMenu();
                    break;
                case "N":
                    DrinkMenu();
                    break;
            }
        }

        public void DrinkMenu()
        {
            int i = 1;
            Console.WriteLine("-----Drink Menu-----");
            foreach (var drink in drinks)
            {
                Console.WriteLine($"{i}. {drink.Name} :    {drink.Price}");
                i++;
            }
            ChoiceDrink();
        }

        public void ChoiceDrink()
        {
            int choose1 = 0;
            string allergy = "";
            do
            {
                Console.WriteLine("Enter your order? (with digit): ");
                choose1 = int.Parse(Console.ReadLine());
                if (choose1 > 6)
                {
                    Console.WriteLine("Lütfen 1 ve 5 arasında bir rakam giriniz!");
                    DrinkMenu(); 
                }

            } while (choose1 < 0 || choose1 > 6);
            switch (choose1)
            {
                case 1:
                    Console.WriteLine("Are you allergic to coffee? (Y/N)");
                    allergy = Console.ReadLine();
                    cost += drinks[0].Price;
                    break;
                case 2:
                    Console.WriteLine("Are you allergic to milk? (Y/N)");
                    allergy = Console.ReadLine();
                    cost += drinks[1].Price;
                    break;
                case 3:
                    Console.WriteLine("Are you allergic to lemon? (Y/N)");
                    allergy = Console.ReadLine();
                    cost += drinks[2].Price;
                    break;
                case 4:
                    Console.WriteLine("Are you allergic to meyan kökü? (Y/N)");
                    allergy = Console.ReadLine();
                    cost += drinks[3].Price;
                    break;
                case 5:
                    Console.WriteLine("Are you allergic to water? (Y/N)");
                    allergy = Console.ReadLine();
                    cost += drinks[4].Price;
                    break;

            }
            switch(allergy.ToUpper())
            {
                case "Y":
                    Console.WriteLine("You can't order it. Choose another drink please!");
                    cost = cost - drinks[choose1 - 1].Price;
                    DrinkMenu();
                    break;
                case "N":
                    Console.WriteLine($"Your total cost = {cost}");
                    Console.WriteLine("Siparişiniz oluşturuldu. Enjoy for meal!");
                break;
            }
        }
    }
}
