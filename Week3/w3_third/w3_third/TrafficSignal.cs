 using System;
namespace w3_third
{
    public delegate void TrafficDel();
    class TrafficSignal
    {

        private string signal = null;
        public event TrafficDel SignalEvent;


        public string Signal
        {
            get { return signal; }
            set { SignalEvent.Invoke(); }
        }


        public void Red()
        {

            Console.WriteLine("\nDo Not Cross Signal");
            //return "Do Not Cross Signal";
        }

        public void Yellow()
        {

            Console.WriteLine("\nReduce Speed. Going to be Red soon");
            //return "Reduce Speed. Going to be Red soon";
        }
        public void Green()
        {

            Console.WriteLine("\nCross Signal");
            //return "Cross Signal";
        }
    }
}
