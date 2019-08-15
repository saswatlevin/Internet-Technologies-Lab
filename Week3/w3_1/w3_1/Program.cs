using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace w3_1
{  
    class Program
    {   
        static void Main(string[] args)
        {
            DataModel 
            Product P = new Product();
            P.InvalidId += WrongValue;
            P.InvalidId += DisplayError;
            int id;
            Console.WriteLine("\nEnter any positive value");
            int.TryParse(Console.ReadLine(),out id);
            Console.WriteLine(P.id);
            Console.Read();
        }

        static void WrongValue()
        {
            Console.WriteLine("Invalid value");
            Console.Read();
        }
        static void DisplayError()
        {
            Console.WriteLine("\nDisplayError");
        }
    }
}
