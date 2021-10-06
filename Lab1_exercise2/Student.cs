using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_exercise2
{
    class Student
    {
        private int id;
        private string name;
        private int birthYear;
        private float mark1;
        private float mark2;
        private float mark3;


        public Student()
        {

        }

        public Student(int id, string name, int birthYear, int mark1, int mark2, int mark3)
        {
            this.id = id;
            this.name = name;
            this.birthYear = birthYear;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public float Mark1
        {
            get { return mark1; }
            
        }
        public float Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public float Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

        public void InputInfo()
        {
            Console.WriteLine("INPUT THE INFORMAATION");
            Console.WriteLine("Input student id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input student birth year: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Input student mark1: ");
            mark1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input student mark2: ");
            mark2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input student mark3: ");
            mark3 = float.Parse(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine("PRINT THE INFORMATION");
            Console.WriteLine("Student id: " + id);
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student birth year: " + birthYear);
            Console.WriteLine("Student mark 1: " + mark1);
            Console.WriteLine("Student mark 2: " + mark2);
            Console.WriteLine("Student mark 3: " + mark3);

        }

        public float AverageMark()
        {
            float averageMark = (mark1 + mark2 + mark3) / 3;
            return averageMark;
        }
        public void MarkStatus()
        {
            float averageMark = (mark1 + mark2 + mark3)/3;
            Console.WriteLine("THE AVERAGE MARK: "+ averageMark );
            if (averageMark > 7 && averageMark <= 10 && mark1 > 5 && mark2 >5 && mark3 > 5)
            {
                Console.WriteLine("This student is allowed to write a thesis");
            }
            else if (averageMark < 7 && averageMark <= 10 && mark1 > 5 && mark2 > 5 && mark3 > 5)
            {
                Console.WriteLine("This student get graduation exam");
            }
            else if (mark1 <= 5 || mark2 <= 5 || mark3 <= 5)
            {
                Console.WriteLine("This student has been retested");
                if (mark1 <= 5)
                {
                    Console.WriteLine("the subject that student has to retest is subject 1");

                }
                if (mark2 <= 5)
                {
                    Console.WriteLine("the subject that student has to retest is subject 2");

                }
                if (mark3 <= 5)
                {
                    Console.WriteLine("the subject that student has to retest is subject 3");

                }
            }
        }

        

        




    }
}
