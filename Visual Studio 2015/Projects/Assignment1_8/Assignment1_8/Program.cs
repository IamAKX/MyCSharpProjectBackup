using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_8
{
    class Variable
    {
        public int a, b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Variable ob = new Variable();
            Console.Write("Enter the value for a :");
            ob.a=Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the value for b :");
            ob.b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Value for a before change :"+ob.a);
            Console.WriteLine("Value for b before change :" +ob.b);
            new Program().swap(ob);
            Console.WriteLine("Value for a after change :" + ob.a);
            Console.WriteLine("Value for b after change :" + ob.b);
            Console.ReadLine();
        }

        private void swap(Variable ob)
        {
            int temp;
            temp = ob.a;
            ob.a = ob.b;
            ob.b = temp;
        }
    }
}
