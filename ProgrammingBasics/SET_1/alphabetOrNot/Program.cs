using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Character !");
            char ch = (char)Console.Read();
            if (ch >= 'A'&& ch <= 'Z' || ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("an alphabet");
            }
            else { Console.WriteLine("Not an alphabet"); }
        }
    }
}
