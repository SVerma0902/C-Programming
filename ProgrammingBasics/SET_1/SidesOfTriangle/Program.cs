using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidesOfTriangle
{
    //Write a program to input all sides of a triangle and check whether triangle is valid or not.
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, side3;

            Console.WriteLine("Enter side1 !");
            Console.WriteLine("Enter side2 !");
            Console.WriteLine("Enter side3 !");
            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            max = Math.Max(side1, Math.Max(side2,side3));
           
            if((max == side1) && (max <(side2 + side3))) { Console.WriteLine("possible"); }
            else if ((max == side2) && (max < (side1 + side3))) { Console.WriteLine("possible"); }
            if ((max == side3) && (max < (side1 + side3))) { Console.WriteLine("possible"); }


        }
    }
}
