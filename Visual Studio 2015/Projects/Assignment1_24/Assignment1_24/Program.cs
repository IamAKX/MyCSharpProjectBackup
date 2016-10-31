using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
                Console.WriteLine(x + " x " + i + " = " + (x * i));
            Console.ReadLine();
        }
    }
}
