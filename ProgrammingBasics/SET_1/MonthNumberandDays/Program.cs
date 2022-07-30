using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNumberandDays
{
    internal class MonthNumberandDays
    {
        static void Main(string[] args)
        {
            //Write a program to input month number and print number of days in that month.
            int month_num;
            Console.WriteLine("enter a month number !!!");
            month_num = Convert.ToInt32(Console.ReadLine());
            if (month_num == 1 || month_num == 3 || month_num == 5 || month_num == 7 || month_num == 8 || month_num == 10 || month_num == 12)
            {
                Console.WriteLine(" days are 31");
            }
            else if (month_num == 4 || month_num == 6 || month_num == 9 || month_num == 10 || month_num == 11)
            {
                Console.WriteLine(" days are 30");
            }
            else 
            {
                Console.WriteLine(" days are 28");
            }
        }
    }
}
