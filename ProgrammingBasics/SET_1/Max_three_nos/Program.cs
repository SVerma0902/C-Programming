using System;

namespace Programming
{
    //2. Write a program to find maximum between three numbers.
    internal class Max_three_nos
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first no!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no!");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no!");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) { Console.WriteLine("A is maximum!"); }
            else if (b > a && b > c) { Console.WriteLine("B is maximum " + b); }
            else { Console.WriteLine("C is maximum " + c); }
        }
    }
}
