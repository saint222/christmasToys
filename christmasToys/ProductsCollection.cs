using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace christmasToys
{
    public class ProductsCollection
    {
        public List <Products> products { get; set; }
     
        public void CheapestProduct()
        {
            Console.WriteLine("A present for the mother-in-law (the cheapest one):");
            var cheapest = products.OrderBy(x => x.prices.price_min.amount).Take(1);

            foreach (var item in cheapest)

            {
                item.ShowPresents();
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        public void MostExpensiveProduct()
        {
            Console.WriteLine("A present for me (the most expensive one):");
            var mostExpensive = products.OrderBy(x => x.prices.price_min.amount).Last();

            mostExpensive.ShowPresents();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void ProductsTillFifty()
        {
            Console.WriteLine("Here is the list of the products with the sum of their prices - 50 BYN:");
            double count = 0;
            var tillFifty = products.OrderBy(x => x.prices.price_min.amount).TakeWhile(x => (count += x.prices.price_min.amount) <=50);
            foreach (var item in tillFifty)
            {
                item.ShowPresents();
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        public void ProductsTillEighty()
        {
            Console.WriteLine("Here is the list of the random products with the sum of their prices - 80 BYN:");
            double count = 0;
            var tillEighty = products.TakeWhile(x => (count += x.prices.price_min.amount) <= 80);
            foreach (var item in tillEighty)
            {
                item.ShowPresents();
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void TotalPrice()
        {
            
            var sum = products.Sum(x => x.prices.price_min.amount);
            Console.WriteLine($"The sum of all present prices is {sum};");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void PriceTillFourty()
        {
            var sum_1 = products.Sum(x => x.prices.price_min.amount >= 40);
            Console.WriteLine($"{sum_1}");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void PriceTillTwentyFour()
        {            
            var tillTwentyFour = products.Count(x => x.prices.price_min.amount <= 25);
            Console.WriteLine($"There are {tillTwentyFour} products which cost is less than 25 BYN. They are:");
            var theyAre = products.Where(x => x.prices.price_min.amount<=25);
            foreach (var item in theyAre)
            {
                item.ShowPresents();
            }
            Console.WriteLine("The End...");
            Console.ReadLine();
        }
    }


}
