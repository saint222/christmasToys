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
            Console.ReadLine();                        
            
            collection.CheapestProduct();            
            collection.MostExpensiveProduct();            
            collection.ProductsTillFifty();
            Console.ReadLine();            

        }
    }
}
