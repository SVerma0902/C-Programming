using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    internal class numbers
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) { Console.WriteLine("positive number"); }
            else if (a == 0) { Console.WriteLine(" number is 0"); }
            else { Console.WriteLine("number is negative"); }

        }
    }
}
