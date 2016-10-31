using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            String s = Console.ReadLine();
            Console.Write("Enter the character to be searched : ");
            char c = Convert.ToChar(Console.ReadLine());
            int f = 0;
            foreach(char x in s)
            {
                if (c == x)
                    f++;
            }
            Console.WriteLine("Frequency of " + c + " = " + f);
            Console.ReadLine();
        }
    }
}
