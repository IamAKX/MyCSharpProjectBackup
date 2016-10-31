using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            int i, j, t, f;
            for(i=0;i<ar.Length;i++)
            {
                Console.Write("enter the element : ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<ar.Length-1;i++)
            {
                for(j=0;j<ar.Length-i-1;j++)
                {
                    if(ar[j]>ar[j+1])
                    {
                        t = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = t;
                    }
                }
            }
            for (i = 0; i < ar.Length; i++)
            {
                f = 1;
                for (j = i + 1; j <= ar.Length - 1; j++)
                {
                    if (ar[i] == ar[j] && ar[i] != '\0')
                    {
                        f++;
                        ar[j] = '\0';
                    }
                }
                if (ar[i] != '\0')
                {
                    Console.WriteLine("Frequency of " + ar[i] + " is " + f);
                }
            }
            Console.ReadLine();
        }
    }
}
