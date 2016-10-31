using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int odd = 0, even = 0, zero = 0,x;
            while (n>0)
            {
                x = n % 10;
                if (x == 0)
                    zero++;
                else
                    if (x % 2 == 0)
                        even++;
                    else
                        odd++;
                n /= 10;
            }
            Console.WriteLine("Odd digits : " + odd + "\nEven digits : " + even + "\nZero digits : " + zero);
            Console.ReadLine();
        }
    }
}
