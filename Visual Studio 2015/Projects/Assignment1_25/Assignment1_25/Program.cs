using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Character : ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 65 && c <= 90 || c >= 97 && c <= 122)
                Console.WriteLine("It is alphabet");
            else
                if(c>=48 &&c<=57)
                    Console.WriteLine("It is digit");
                else
                    Console.WriteLine("It is special character");
            Console.ReadLine();
        }
    }
}
