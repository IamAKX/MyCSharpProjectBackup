using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Base : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Indices : ");
            int y = Convert.ToInt32(Console.ReadLine());
            long z = 1;
            for (int i = 0; i < y; i++)
                z *= (long)x;
            Console.WriteLine("{0}^{1}={2:N0}", x, y, z);
            Console.ReadLine();
        }
    }
}
