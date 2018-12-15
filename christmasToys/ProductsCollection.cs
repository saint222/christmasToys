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
        public void Sorted()
        {
            var cheapest = products.OrderBy(x => x.prices.price_min.amount);

            foreach (var item in cheapest)
            
            {
                
            }

            Console.ReadLine();
        }
        public void CheapestProduct()
        {
            var cheapest = products.Take(1);

            foreach (var item in cheapest)

            {
                item.ShowPresents();
            }

            Console.ReadLine();
        }

    }


}
