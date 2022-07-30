using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfNotes
{
    //Write a program to count total number of notes in given amount.
    internal class Program
    {
        static void Main(string[] args)
        {
            int amounts, notes10, notes50, notes100;
            notes50 = notes100 = notes10 = 0;
            Console.WriteLine("Enter a amount !");
            amounts = Convert.ToInt32(Console.ReadLine());
            
            if(amounts >= 100)
            {
                notes100 = amounts / 100;
                amounts = amounts - (100 * notes100);
            }
            if(amounts >= 50) {
                notes50 = amounts / 50;
                amounts = amounts - (50 * notes50);
            }
           if(amounts >=10)
            {
                notes10 = amounts / 10;
                amounts = amounts - (10 * notes10);
            }

           Console.WriteLine("100 =" +notes100);
            Console.WriteLine("50 = " + notes50);
            Console.WriteLine("10 = " + notes10);
        }
    }
}
