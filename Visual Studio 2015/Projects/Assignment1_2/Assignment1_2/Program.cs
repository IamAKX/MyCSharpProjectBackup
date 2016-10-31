using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of arrey : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            int i,min,max;
            for(i=0;i<n;i++)
            {
                Console.Write("Enter the element : ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = min = ar[0];
            for (i = 0; i < n; i++)
            {
                if (max < ar[i])
                    max = ar[i];
                if (min > ar[i])
                    min = ar[i];
            }
            Console.WriteLine("\nMaximuim element : " + max);
            Console.WriteLine("Minimum element : " + min);
            Console.ReadLine();
        }
    }
}
