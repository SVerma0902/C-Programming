using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    //Write a program to input angles of a triangle and check whether triangle is valid or not.
    internal class Program
    {
        static void Main(string[] args)
        {
            int angle1, angle2, angle3;
   
            Console.WriteLine("Enter angle1 !");
            Console.WriteLine("Enter angle2 !");
            Console.WriteLine("Enter angle3 !");
            angle1 = Convert.ToInt32(Console.ReadLine());
            angle2 = Convert.ToInt32(Console.ReadLine());
            angle3 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            sum = angle1 + angle2 + angle3;

            if(sum == 180)
            {
                Console.WriteLine("valid triangle");
            }
            else { Console.WriteLine(" not a valid triangle"); }
        }
    }
}
