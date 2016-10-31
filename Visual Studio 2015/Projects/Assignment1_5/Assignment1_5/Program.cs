using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_5
{
    class Customer
    {
        public string name, num;
        public double bal;
        public void Accept()
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter A/C Number : ");
            num = Console.ReadLine();
            Console.Write("Enter Balance : ");
            bal = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Program
    {
        static Customer[] ar = new Customer[20];
        static void Main(string[] args)
        {
            int i,j=0;
            for(i=0;i<20;i++)
            {
                Customer ob = new Customer();
                ob.Accept();
                if (ob.bal < 100.0)
                    ar[j++] = ob;
            }
            Console.WriteLine("Customers having balance below Rs. 100 are :");
            foreach(Customer c in ar)
            {
                Console.WriteLine(c.name + "\t" + c.num);
            }
            Console.Read();
        }
    }
}
