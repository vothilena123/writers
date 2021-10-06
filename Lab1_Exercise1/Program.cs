using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog p = new Catalog();
            int select;
            bool entered = false;
            

            do
            {
                Console.WriteLine("\n----Phones Management System----");
                Console.WriteLine("\t1. Add phone");
                Console.WriteLine("\n\t2.Display All");
                Console.WriteLine("\n\t3.Search phone by model");
                Console.WriteLine("\n\t4.Delete phone by model");
                Console.WriteLine("\n\t5.Update phone by model");
                Console.WriteLine("\n\t6.Exit");
                Console.Write("\n\tPlease enter your select: ");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                      
                        p.Add();                                                   
                        break;
                    case 2:
                        if (true)
                        {                          
                                p.Show();
                            
                        }
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    case 3: 
                        if (true)
                        {
                            Console.WriteLine("Input the model number you want to search");
                            int m = int.Parse(Console.ReadLine());
                            p.SearchByModel(m);
                        } 
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    case 4:
                        if (true)
                        {
                            Console.WriteLine("Input the model number you want to delete");
                            int k = int.Parse(Console.ReadLine());
                            p.DeletePhone(k);
                        }
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    case 5:
                        if (true)
                        {
                            p.UpdatePhone();
                        }
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input value!");
                        break;
                }       
            } while (select != 6);
            Console.WriteLine("Exit the program");
            Console.ReadKey();
            
            
        }
    }
}
