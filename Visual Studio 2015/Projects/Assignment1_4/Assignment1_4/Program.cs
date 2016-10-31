using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            int i, min, max;
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter the element : ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            new Program().sort(ar,n);

        }

        private void sort(int[] ar,int n)
        {
            int i, j,t;
                for(i=0;i<n-1;i++)
                {
                    for(j=0;j<n-i-1;j++)
                    {
                        if(ar[j]>ar[j+1])
                        {
                            t = ar[j];
                            ar[j] = ar[j + 1];
                            ar[j + 1] = t;

                        }
                    }
                }
  
            printArray(ar);
        }

        private void printArray(int[] ar)
        {
            Console.WriteLine("Sorted Array is :");
            foreach(int x in ar)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
