using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace christmasToys
{
     public class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the list ov available presents with their prices:");
            Console.ReadLine();
            string json;
            using (var reader = new StreamReader("PresentsJSON.txt"))
            {
                json = reader.ReadToEnd();
            }            
            ProductsCollection collection = JsonConvert.DeserializeObject<ProductsCollection>(json);            
            foreach (var present in collection.products)
            {
                present.ShowPresents();                
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            collection.CheapestProduct();            
            collection.MostExpensiveProduct();            
            collection.ProductsTillFifty();
            collection.ProductsTillEighty();
            collection.TotalPrice();
            collection.PriceTillFourty();
            collection.PriceTillTwentyFour();
            Console.ReadLine();         

        }
    }
}
