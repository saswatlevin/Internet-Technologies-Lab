using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_second
{
    class Program
    {
       

        static void Main(string[] args)
        { Program P = new Program();
            double cost = 0;
            double GstVal = 0;
            string name="abc";
            Item A = new Item();
            A.CostEvent += StartCalcGst;
            Console.WriteLine("\n Enter Product Name");
            name=Console.ReadLine();
            Item.Name = name;
            Console.WriteLine("\nEnter a price");
            cost = double.Parse(Console.ReadLine());
            A.Cost = cost;
            GstVal= A.CalcGst(cost);
            Console.WriteLine("\n The GST for " + cost +" is= ");
            Console.Write(GstVal);
            Console.Read();
        }

        static void StartCalcGst()
        {
            Console.WriteLine("\nIn StartCalcGst");
                
        }
    }
}
