using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence : ");
            string s = Console.ReadLine();
            string[] words=s.Split(' ');
            Console.Write("Reversed word : ");
            for (int i = words.Length - 1; i >= 0; i--)
                Console.Write(words[i] + " ");
            Console.ReadLine();
        }
    }
}
