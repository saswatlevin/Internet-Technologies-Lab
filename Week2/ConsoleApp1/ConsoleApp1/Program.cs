using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            Console.WriteLine("\n Enter 2 numbers");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out a)
                 && int.TryParse(Console.ReadLine(), out b))
            {
               
                Console.WriteLine("\n a+b=" + Sum(a,b));
                
            }
            else
            {
                Console.WriteLine("\n Error");
               
            }
            Console.Read();
        }

        private static int Sum(int a,int b)
        {
            a = a + b;
            return a;
        }
    }
}
