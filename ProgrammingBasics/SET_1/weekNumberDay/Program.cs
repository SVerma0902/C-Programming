using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekNumberDay
{
    internal class Program
    //Write a program to input week number and print week day.

    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter a number !");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THRUSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;

            }

        }
    }
}
