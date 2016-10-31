using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_21
{
    struct Student
    {
        public string name;
        public int roll, mark1, mark2, mark3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[5];
            int i,j, avg1,avg2;
            Student temp;
            for(i=0;i<5;i++)
            {
                Console.WriteLine("Enter details of Student " + (i + 1));
                Student s;
                Console.Write("Enter name :");
                s.name = Console.ReadLine();
                Console.Write("Enter roll :");
                s.roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter MArk 1 :");
                s.mark1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Mark 2 :");
                s.mark2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Mark 3 :");
                s.mark3 = Convert.ToInt32(Console.ReadLine());
                stu[i] = s;
            }
            for(i=0;i<4;i++)
            {
                for(j=0;j<4-i;j++)
                {
                    avg1=calAVG(stu[j]);
                    avg2 = calAVG(stu[j+1]);
                    if(avg1<avg2)
                    {
                        temp = stu[j];
                        stu[j] = stu[j + 1];
                        stu[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nNAME\tROLL\tMARK 1\tMARK 2\tMARK 3\tAVERAGE");
            foreach (Student a in stu)
                Console.WriteLine(a.name + "\t" + a.roll + "\t" + a.mark1 + "\t" + a.mark2 + "\t" + a.mark3 + "\t" + calAVG(a));
            Console.ReadLine();
        }
        static int calAVG(Student x)
        {
            return (x.mark1 + x.mark2 + x.mark3) / 3;
        }
    }
}
