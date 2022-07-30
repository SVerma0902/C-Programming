using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelORnot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Character !");
            char Ch = (char)Console.Read();
            if (Ch == 'a' || Ch == 'e' || Ch == 'i' || Ch == 'o' || Ch == 'u' || Ch == 'A' || Ch == 'E' || Ch == 'I' || Ch == 'O' || Ch == 'U')
            {
                Console.WriteLine("a vowel");
            }
            else { Console.WriteLine("Not an vowel"); }
        }
    }
}
