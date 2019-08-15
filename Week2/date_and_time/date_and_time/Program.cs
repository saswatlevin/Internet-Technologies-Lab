using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_and_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yyyy = 0, hh = 0, mmmm = 0, ss = 0;
            long ticks=0;
            string hour = "hr";
            string minute = "mn";
            string second = "se";
            string input = "Date";
            string getNum = "Nu";
            string day = "da";
            string month = "mo";
            string year = "yr";

            Console.WriteLine("Enter DD:MM:YYYY:hh:mm:ss");
            input = Convert.ToString(Console.ReadLine());

            hour = input.Substring(0, 2);
            Console.WriteLine("\nhour="+hour);

            Console.WriteLine("\n"+input+" "+"LENGTH="+input.Length);
            Console.WriteLine("\n Enter the number of ticks (Range: 1e7 to 9.9e11)");
            
            long.TryParse(Console.ReadLine(),out ticks);
            Console.Read();

        }
    }
}
