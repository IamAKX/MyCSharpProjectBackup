using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    public class Books
    {
        public string Name, Author, ISBN;
        public void Accept()
        {
            Console.Write("Enter ISBN number : ");
            ISBN = Console.ReadLine();
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Author : ");
            Author = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("Book ISBN : "+ISBN);
            Console.WriteLine("Book Name : " + Name);
            Console.WriteLine("Book Author : " + Author+"\n");
        }

    }
    class Program
    {
        static List<Books> l = new List<Books>();
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to Add Book Information");
            Console.WriteLine("Press 2 to Display Book Information");
            Console.WriteLine("Press 3 to Display Book Information by Given Author");
            Console.WriteLine("Press 4 to Display the Count of Book");
            Console.WriteLine("Press 5 Exit\n");
            int ch;
            do
            {
                Console.Write("Enter Your Choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Books obj = new Books();
                        obj.Accept();
                        l.Add(obj);
                        Console.WriteLine("Book added successfully!!\n");
                        break;
                    case 2:
                        if (l.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            Console.WriteLine("Books in Library:\n");
                            foreach (Books b in l)
                                b.Show();
                        }
                        break;
                    case 3:
                        if (l.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            Console.Write("Enter the Book's Author :");
                            string auth = Console.ReadLine();
                            foreach (Books b in l)
                            {
                                if (b.Author == auth)
                                    b.Show();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Number of books is " + l.Count() + "\n");
                        break;
                    default:
                        Console.WriteLine("Ooopsss!! Invalid Input. Try again.\n");
                        break;

                }


            } while (ch != 5);
        }
    }
}
