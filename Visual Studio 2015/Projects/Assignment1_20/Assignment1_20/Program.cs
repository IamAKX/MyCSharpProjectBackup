using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            for(int i = 0;i<ch.Length;i++)
            {
                if (ch[i] == 'a')
                    ch[i] = '*';
            }
            Console.WriteLine("Modified string : " + new string(ch));
            Console.ReadLine();
        }
    }
}
