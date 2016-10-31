using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_22
{
    public class Books
    {
        public string Name, Author,Publisher;
        public int ISBN;
        public double cost;
        public void Accept()
        {
            Console.Write("Enter ISBN number : ");
            ISBN =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Author : ");
            Author = Console.ReadLine();
            Console.Write("Enter Publisher : ");
            Publisher = Console.ReadLine();
            Console.Write("Enter Cost : ");
            cost = Convert.ToDouble(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("Book ISBN : " + ISBN);
            Console.WriteLine("\tBook Name : " + Name);
            Console.WriteLine("\tBook Author : " + Author);
            Console.WriteLine("\tBook Publisher : " + Publisher);
            Console.WriteLine("\tBook Cost : " + cost + "\n");
        }

    }
    class Program
    {
        static Books[] ar;
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Books : ");
            int n = Convert.ToInt32(Console.ReadLine());
            ar = new Books[n];
            int i, j;
            for (i = 0; i < n;i++)
            {
                Console.WriteLine("Details of Book " + (i + 1));
                Books ob = new Books();
                ob.Accept();
                ar[i] = ob;
            }
            new Program().sortBooks(n);
            Console.WriteLine("\nPress 1 to Display Book Information by Given Author");
            Console.WriteLine("Press 2 to Display Book Information by Given Publisher");
            Console.WriteLine("Press 3 to Display All Books of cost less than Rs.500");
            Console.WriteLine("Press 4 Display All Books");
            Console.WriteLine("Press 5 to Exit\n");
            int ch;
            do
            {
                Console.Write("Enter Your Choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        if (ar.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            Console.Write("Enter the Book's Author :");
                            string auth = Console.ReadLine();
                           
                            foreach (Books b in ar)
                            {
                                if (b.Author == auth)
                                    b.Show();
                            }
                        }
                        break;
                    case 2:
                        if (ar.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            Console.Write("Enter the Book's Publiser :");
                            string pub = Console.ReadLine();
                           
                            foreach (Books b in ar)
                            {
                                if (b.Publisher == pub)
                                    b.Show();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Number of books of cost less than Rs.500");
                        if (ar.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            
                           
                            foreach (Books b in ar)
                            {
                                if (b.cost<500)
                                    b.Show();
                            }
                        }
                        break;
                    case 4:
                        if (ar.Count() == 0)
                            Console.WriteLine("Library is empty!!\n");
                        else
                        {
                            
                            Console.WriteLine("ISBN\tNAME\tAUTHOR\tPUBLISHER\tCOST");
                            foreach (Books b in ar)
                                b.Show();
                        }
                        break;
                        
                    default:
                        Console.WriteLine("Ooopsss!! Invalid Input. Try again.");
                        break;

                }


            } while (ch != 5);
        }

        private void sortBooks(int n)
        {
            int i, j;
            Books temp;
            for(i=0;i<n-1;i++)
            {
                for(j=0;j<n-i-1;j++)
                {
                    if(ar[j].ISBN>ar[j+1].ISBN)
                    {
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j+1]=temp;
                    }
                }
            }
        }
    }

}
