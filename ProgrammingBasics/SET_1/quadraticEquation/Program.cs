using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadraticEquation
{
    internal class Program
    {
        //Write a program to find all roots of a quadratic equation.
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Enter a !");
            Console.WriteLine("Enter b !");
            Console.WriteLine("Enter c !");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double x,y1,y2;
            x = Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)));
                y1 = (-b + x) / (2 * a);
                y2 = (-b - x) / (2 * a);
            Console.WriteLine("the roots of a quadratic equation are 1. " + y1);
            Console.WriteLine("the roots of a quadratic equation are 2. " + y2);
        }
    }
}
