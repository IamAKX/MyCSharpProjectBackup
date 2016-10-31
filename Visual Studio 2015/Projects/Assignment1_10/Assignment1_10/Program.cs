using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();
            int f = 0,i;
            char[] str = s.ToCharArray();
            for (i = 0; i < str.Length; )
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    for (int j = i; j < str.Length - 1; j++)
                        str[j] = str[j + 1];
                    str[str.Length - f - 1] = '\0';
                    f++;
                }
                else
                {
                    i++;
                }
            }
            string res = new string(str);
            Console.WriteLine("Manipulated String : " + res);
            Console.ReadLine();
        }
    }
}
