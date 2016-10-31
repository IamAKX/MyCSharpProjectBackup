using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first side : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second side : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third side :");
            int c = Convert.ToInt32(Console.ReadLine());
            if (new Program().checkValidity(a, b, c))
                Console.WriteLine("Triangle of given side is Valid");
            else
                Console.WriteLine("Triangle of given side is not valid");
            Console.ReadLine();
        }

        private bool checkValidity(int a, int b, int c)
        {
            if((a+b)>c && (b+c)>a && (a+c)>b)
                return true;
            else
                return false;
        }
    }
}
