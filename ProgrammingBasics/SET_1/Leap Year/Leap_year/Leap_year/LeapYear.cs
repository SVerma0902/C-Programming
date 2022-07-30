using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4 == 0) { Console.WriteLine("leap year");}
            else { Console.WriteLine("Not a leap year"); }
        }
    }
}

