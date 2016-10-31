using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII value of " + ch + " is " + (int)ch);
            Console.WriteLine("Successor of " + ch + " is " + (char)(ch+1));
            Console.WriteLine("Predecessor of " + ch + " is " + (char)(ch-1));
            Console.ReadLine();
        }
    }
}
