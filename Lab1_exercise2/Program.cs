using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want to manage");
            int n = int.Parse(Console.ReadLine());
            bool entered = false;
            int select;
            Student[] student = new Student[n];

            do
            {
                Console.WriteLine("\n----Student Management System----");
                Console.WriteLine("\t1. Input student");
                Console.WriteLine("\n\t2.Display All");
                Console.WriteLine("\n\t3.The status of students");
                Console.WriteLine("\n\t4.The status of students");
                Console.WriteLine("\n\t5.Exit");
                Console.Write("\n\tPlease enter your select: ");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            student[i] = new Student();
                            student[i].InputInfo();
                        }
                        break;
                    case 2:
                        if (true)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                student[i].PrintInfo();
                            }

                        }
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    case 3:
                        if (true)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                student[i].PrintInfo();
                                student[i].MarkStatus();
                            }
                        }
                        else
                        {
                            Console.WriteLine("List phone is empty, you need to add first");
                        }
                        break;
                    case 4:
                        if (true)
                        {
                            float thesis = 0;
                            float graduate = 0;
                            float retest = 0;
                            for (int i = 0; i < n; i++)
                            {
                                if (student[i].AverageMark() > 7 && student[i].AverageMark() <= 10)
                                    thesis++;
                                else if (student[i].AverageMark() < 7 && student[i].AverageMark() > 5)
                                    graduate++;
                                else
                                    retest++;

                            }
                            Console.WriteLine("the number of students that they are allowed to write a thesis : " + thesis);
                            Console.WriteLine("the number of students that they are allowed to get the graduation exams : " + graduate);
                            Console.WriteLine("the number of students that they have to retest : " + retest);

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
            } while (select != 5);
            Console.WriteLine("Exit the program");
            Console.ReadKey();

        }
    }
}
