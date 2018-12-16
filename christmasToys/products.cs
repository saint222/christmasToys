using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmasToys
{
    public partial class Products
    {
        public string name_prefix { get; set; }
        public Prices prices { get; set; }
       

        public void ShowPresents()

        {
            Console.WriteLine($"{name_prefix} по цене { prices.price_min.amount} BYN за штуку;");
        }


    }
}
