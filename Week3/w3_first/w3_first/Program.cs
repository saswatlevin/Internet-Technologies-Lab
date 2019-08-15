using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_first
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Item B = new Item();
            B.PriceChange += ReportPriceChange;
            int price;
            Console.WriteLine("\nEnter Price");
            int.TryParse(Console.ReadLine(),out price);
            B.Price = price;/*Calls get function of Price 
                            and takes value of local var price to B object*/
            //B.CallPriceEvent();
            Console.WriteLine("\n B.price=" + B.Price);
            Console.WriteLine("Price Changed");
            Console.Read();
        }
        

        static void ReportPriceChange()
        {
            Console.WriteLine("\n");
        }
    }
}
