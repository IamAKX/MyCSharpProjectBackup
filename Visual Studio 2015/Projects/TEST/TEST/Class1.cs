using System;
using System.Collections.Generic;

class Customer
{
    String ID, Name;
    Float bal;
}
class Calculate
{
    ArrayList<Customer> al = new ArrayList<Customer>();
    static void Main()
    {
        for(int i=0;i<5;i++)
        {
            Customer obj =new Customer();
            Console.WriteLine("Enter ID,NAME and BALANCE :");
            obj.ID = Console.ReadLine();
            obj.Name = Console.ReadLine();
            obj.bal = Convert.ToInt32(Console.ReadLine());
            if (obj.bal < 100)
                al.Add(obj);
        }
        foreach (Customer x in al)
        {
            Console.WriteLine(x.ID + "\t" + x.Name);
        }
    }
}
