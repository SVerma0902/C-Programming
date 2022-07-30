using System;

namespace electricUnit
{
    //    21. Write a program to input electricity unit charges and calculate total electricity bill according to the
    //given condition:
    //a.For first 50 units Rs. 0.50/unit
    //b. For next 100 units Rs. 0.75/unit
    //c. For next 100 units Rs. 1.20/unit
    //d. For unit above 250 Rs. 1.50/unit
    //e. An additional surcharge of 20% is added to the bill
    internal class Program
    {
        static void Main(string[] args)
        {
            double unit, bill=0.0;

            Console.WriteLine("Enter electricity units consumed !");
            unit = Convert.ToDouble(Console.ReadLine());

            if (unit <= 50)
                bill = unit * 0.50;

            else if (unit > 50 && unit <= 150)
                bill = (50 * 0.50) + (unit - 50) * 0.75;

            else if (unit > 150 && unit <= 250)
                bill = (50 * 0.50) + (100*0.75) + ((unit-150)*1.20);

            else if (unit > 250)
                bill = (50 * 0.50) + (100 * 0.75) + (100*1.20) + ((unit-250)*1.50);

            bill = bill + (bill * 0.20);

            Console.WriteLine(bill);

        }
    }
}
