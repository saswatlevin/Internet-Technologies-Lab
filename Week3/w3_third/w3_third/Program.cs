using System;


namespace w3_third
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string result = "abc";
            TrafficSignal T = new TrafficSignal();
            T.SignalEvent += T.Red;
            T.SignalEvent += T.Yellow;
            T.SignalEvent += T.Green;

            T.Signal = result;

            //result =Console.ReadLine();
           Console.Read();
        }
        

    }
}
