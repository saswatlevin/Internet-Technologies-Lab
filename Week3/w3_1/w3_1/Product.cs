using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_1
{
    public delegate void InvalidDelegate();
    public class Product
    {
        public event InvalidDelegate InvalidId;
        private int id;
        //private string name;
        public string Name
        {
            get;//auto property
            set;//auto property
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    InvalidId.Invoke();
                }
            }
        }
        
    }
}
