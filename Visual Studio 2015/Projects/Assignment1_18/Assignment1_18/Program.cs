using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.Write("Enter the number of entries : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("Enter the number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                if(checkPrime(x))
                    ar[k++] = x;
            }
            Console.WriteLine("Prime numbers are : ");
            foreach (int a in ar)
            {
                if (a != 0)
                    Console.Write(a + "  ");
            }
            Console.ReadLine();
        }

        private static bool checkPrime(int x)
        {
            int f = 0;
            for(int i=2;i<x;i++)
            {
                if(x%i==0)
                {
                    f++;
                    break;
                }
            }
            if (f == 0)
                return true;
            else
                return false;
        }
    }
}
