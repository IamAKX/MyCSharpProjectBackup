using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string s = Console.ReadLine(),r;
            int ch;
                Console.WriteLine("\nPress 1 to calculate length of string ");
                Console.WriteLine("Press 2 to reverse a string");
                Console.WriteLine("Press 3 to concatenating with another string");
                Console.WriteLine("Press 4 to copy one string to another");
                Console.WriteLine("Press 5 to compare two string");
                Console.WriteLine("Press 6 to exit");
                do
                {
                    Console.Write("Enter the choice : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                        Console.WriteLine("Lenghth of string " + s.Length);
                    else
                        if (ch == 2)
                        {
                            r = s;
                            char[] charArray = r.ToCharArray();
                             Array.Reverse( charArray );

                             Console.WriteLine("Reverse of string " + new string(charArray));
                        }
                        else
                            if (ch == 3)
                            {
                                Console.Write("Enter another string : ");
                                r = Console.ReadLine();
                                Console.WriteLine("Concatenated string " + String.Concat(s, r));
                            }
                            else
                                if (ch == 4)
                                {
                                    string x=string.Copy(s);
                                    Console.WriteLine("Copy of string " + x);
                                }
                                else
                                    if (ch == 5)
                                    {
                                        Console.Write("Enter another string : ");
                                        r = Console.ReadLine();
                                        Console.WriteLine("Comparing two " + s.CompareTo(r));
                                    }
                                    else
                                        Console.WriteLine("Wrong choice!! Try again");

                } while (ch != 6);
        }
    }
}
