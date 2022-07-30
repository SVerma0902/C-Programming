using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCase
{
    internal class Program
    {
         static void Main(string[] args)
        {
            
                Console.WriteLine("Enter a Character !");
                char ch = (char)Console.Read();
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("uppper case!!!");
            }
            else if (ch >= 'a' && ch <= 'z') { Console.WriteLine("a lowerrr case"); }
          
            
        }
    }
}
