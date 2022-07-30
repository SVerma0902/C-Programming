using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_if_divisible
{
    internal class check_if_divisible
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a no and check if divisible by 5 and 11 !");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%5 == 0 && a%11 == 0) { Console.WriteLine("number is divisible"); }
            else { Console.WriteLine("not divisible by 5 and 11"); }
        }
    }
}
