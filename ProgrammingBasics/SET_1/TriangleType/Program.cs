using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleType
{
    internal class Program
    {
        //Write a program to check whether the triangle is equilateral, isosceles or scalene triangle.
        static void Main(string[] args)
        {
            int side1, side2, side3;

            Console.WriteLine("Enter side1 !");
            Console.WriteLine("Enter side2 !");
            Console.WriteLine("Enter side3 !");
            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());

            if(side1 == side2 && side2 == side3) { Console.WriteLine("equilateral "); }
            else if (side1 != side2 && side2 != side3 && side3 != side1) { Console.WriteLine(" Scalene "); }
            else { Console.WriteLine(" isoceles "); }

        }
    }
}
