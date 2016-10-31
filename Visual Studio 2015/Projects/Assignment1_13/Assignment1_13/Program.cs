using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the no. of Rows : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no. of Column : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[m,n];
            int i, j, sum = 0;
            for(i=0;i<m;i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.Write("Enter the element : ");
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += ar[i, j];
                }
            }
            Console.WriteLine("Sum of the elements = " + sum);
            Console.ReadLine();
        }
    }
}
