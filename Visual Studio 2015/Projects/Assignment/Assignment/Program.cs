using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Customer
    {
        public string ID, Name;
        public float bal;

        public void takeInput()
        {
            ID = Console.ReadLine();
            Name = Console.ReadLine();
            bal = Convert.ToInt32(Console.ReadLine());
        }

       
    }
    class Program
    {
        static List<Customer> al = new List<Customer>();
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Customer obj = new Customer();
                Console.WriteLine("Enter ID,NAME and BALANCE :");
                obj.takeInput();
                if (obj.bal < 100)
                    al.Add(obj);
            }
            foreach (Customer x in al)
            {
                Console.WriteLine(x.ID + "\t" + x.Name);
            }
            Console.ReadLine();
        }
    }

}
