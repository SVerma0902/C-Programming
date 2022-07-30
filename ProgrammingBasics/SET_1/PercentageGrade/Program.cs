using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageGrade
{

//    Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and
//   Computer.Calculate percentage and grade according to following:
//a.Percentage &gt;= 90% : Grade A
//b.Percentage &gt;= 80% : Grade B
//c.Percentage &gt;= 70% : Grade C
//d.Percentage &gt;= 60% : Grade D
//e.Percentage &gt;= 40% : Grade E
//f.Percentage &lt; 40% : Grade F
    internal class Program
    {
        static void Main(string[] args)
        {
            double phy, che, bio,mat,com;

            Console.WriteLine("Enter phy !");
            Console.WriteLine("Enter che !");
            Console.WriteLine("Enter bio !");
            Console.WriteLine("Enter mat !");
            Console.WriteLine("Enter com !");
            phy = Convert.ToDouble(Console.ReadLine());
            che = Convert.ToDouble(Console.ReadLine());
            bio = Convert.ToDouble(Console.ReadLine());
            mat = Convert.ToDouble(Console.ReadLine());
            com = Convert.ToDouble(Console.ReadLine());

            double tot = phy+che+bio+mat+com;
            double percentage = tot / 500 * 100;

            if (percentage > 90)
                Console.WriteLine("A");

            else if(percentage >= 80 && percentage <90)
                Console.WriteLine("B");

            else if (percentage >= 70 && percentage < 80)
                Console.WriteLine("C");

            else if (percentage >= 60 && percentage < 70)
                Console.WriteLine("D");

            else if (percentage >= 40 && percentage < 60)
                Console.WriteLine("E");

            else if (percentage < 40)
                Console.WriteLine("F");

        }
    }
}
