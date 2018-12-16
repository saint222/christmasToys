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
            Console.WriteLine("And now - a present for a mother-in-law (the cheapest one)!");
            var cheapest = products.OrderBy(x => x.prices.price_min.amount).Take(1);

            foreach (var item in cheapest)

            {
                item.ShowPresents();
            }

            Console.ReadLine();
        }
        public void MostExpensiveProduct()
        {
            Console.WriteLine("A present for me (the most expensive one)!:)");
            var mostExpensive = products.OrderBy(x => x.prices.price_min.amount).Last();

            mostExpensive.ShowPresents();

            Console.ReadLine();
        }

        public void ProductsTillFifty()
        {
            Console.WriteLine("Here is the list of the products with the sum of their prices - 50 BYN;");
            double count = 0;
            var tillFifty = products.OrderBy(x => x.prices.price_min.amount).TakeWhile(x => (count += x.prices.price_min.amount) <=50);
            foreach (var item in tillFifty)
            {
                item.ShowPresents();
            }

            Console.ReadLine();
        }

    }


}
