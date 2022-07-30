using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Loss
{
    // Write a program to calculate profit or loss.
    internal class Program
    {
        static void Main(string[] args)
        {
            double cp, sp;

            Console.WriteLine("Enter mp !");
            Console.WriteLine("Enter sp !");
          
            cp = Convert.ToDouble(Console.ReadLine());
            sp = Convert.ToDouble(Console.ReadLine());

            double x;

            if (sp > cp)
                Console.WriteLine("Profit : " + (sp - cp));


            else
                Console.WriteLine("loss : " + (cp - sp));

        }
    }
}
