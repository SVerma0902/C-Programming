using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSalary
{
    internal class Program
    {
//Write a program to input basic salary of an employee and calculate its Gross salary according to
//following:
//a.Basic Salary <= 10000 : HRA = 20%, DA = 80%
//b.Basic Salary <= 20000 : HRA = 25%, DA = 90%
//c.Basic Salary > 20000 : HRA = 30%, DA = 95%
        static void Main(string[] args)
        {
            double sal,gs =0.0;

            Console.WriteLine("Enter sal !");
            sal = Convert.ToDouble(Console.ReadLine());

            if(sal <= 10000)
            {
                gs = sal + (sal * 0.2) + (sal * 0.8);
            }
            else if(sal <= 20000)
            {
                gs = sal + (sal * 0.25 ) +(sal * 0.90);
            }
            else if (sal > 20000)
            {
                gs = sal + (sal * 0.30) + (sal * 0.95);
            }

            Console.WriteLine("gross sal := " + gs);
        }
    }
}
