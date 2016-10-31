using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, x, m;
            m=n;
            while(n>0)
            {
                x = n % 10;
                if (n == m)
                    sum += x;
                n /= 10;
                if (n == 0)
                    sum += x;
            }
            Console.WriteLine("Sum of first and last digit is " + sum);
            Console.ReadLine();
        }
    }
}
