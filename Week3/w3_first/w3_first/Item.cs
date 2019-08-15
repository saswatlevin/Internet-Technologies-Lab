using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_first
{
    public delegate void PriceDelegate();
    public class Item
    {
        
        private int price;
        public event PriceDelegate PriceChange;

        public void CallPriceEvent()
        {
            PriceChange.Invoke();
           
        }

        public string Name
        {
            get;//auto property
            set;//auto property
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value > 0)
                {
                    price = value;
                    PriceChange.Invoke();
                }
               
            }
            
            
        }
    }
}
