using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCharacter
{
    internal class check_character
    //Write a program to input any character and check whether it is alphabet, digit or special character.
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter a Character !");
                char ch = (char)Console.Read();
            if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("an alphabet");
            }
            else if (ch >= '0' && ch <= '9') { Console.WriteLine("a digit"); }
            else
            {
                Console.WriteLine("special character");
            }
            }
        }
    }

