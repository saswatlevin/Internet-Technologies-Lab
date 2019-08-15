using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_second
{   
    
    public class Item
    {
        public delegate void CostDelegate();
        private double cost;

        public event CostDelegate CostEvent; 
        public static string Name
        {
            get;
            set;
        }
         
        public double Cost
        {
            get
            {
                return cost;
            }

            set
            {
                if(value>0)
                {
                    cost = value;
                    CostEvent.Invoke();
                    
                }
            }
        }
       
        public double CalcGst(double cost) {
            double x = (cost*0.08);
            return x;
       }
    }
}
