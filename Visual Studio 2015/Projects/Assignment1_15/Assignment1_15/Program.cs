using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of z : ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2:N0}",x,y+z
                ,(long)Math.Pow(x, (y + z)));
            Console.ReadLine();
        }
    }
}
