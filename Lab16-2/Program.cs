using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Lab162 
{
    

        class Program
        {
            static void Main(string[] args)
            {
              string jsonstring = String.Empty;
              using (StreamReader sr = new StreamReader("../../../Products.json"))
              {
                   jsonstring = sr.ReadToEnd();
              }
               Product[] products = JsonSerializer.Deserialize<Product[]>(jsonstring);

               Product maxprroduct = products[0];
               foreach(Product e in products)
               {
                  if (e.Price>maxprroduct.Price)
                  {
                    maxprroduct = e;
                  }
               }
               Console.WriteLine($"{maxprroduct.Code} {maxprroduct.Title} {maxprroduct.Price}");
               Console.ReadKey();
            }
        }
 }
