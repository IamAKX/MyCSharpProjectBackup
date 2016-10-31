using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Basic Salary : ");
            double b = Convert.ToDouble(Console.ReadLine()),gross;
            if (b >= 5000)
                gross = b + (b * 0.15) + (b * 1.5);
            else
                gross = b + (b * 0.1) + (b * 1.1);
            Console.WriteLine("Gross Salaray = " + gross);
            Console.ReadLine();
        }
    }
}
