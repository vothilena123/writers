using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Exercise1
{
    class Catalog
    {
        public List<Phone> list;
        


        public Catalog()
        {
            list  = new List<Phone>();

        }

        public void Add()
        {
            int i = 0;
            Console.Write("How many phone do you want to add? :");
            int n = int.Parse(Console.ReadLine());
            Phone[] newPhone = new Phone[n];
            do
            {
                newPhone[i] = new Phone();
                newPhone[i].InputInfo();
                list.Add(newPhone[i]);
                i++;
            } while (i < n);
          

            Console.WriteLine("You can't add more");


        }

        public void Show()
        {
            Console.WriteLine("LIST OF PHONE:");
            for (int i= 0; i < list.Count; i++)
            {
                list[i].PrintInfo();
            }

        }

        public void SearchByModel(int model)
        {
            bool found = false;
            foreach (var searchPhone in list)
            {
                if (searchPhone.Model == model)
                {
                    searchPhone.PrintInfo();
                    found = true;
                    break;
                }

            }
            if (!found) //tương đương if(found == false)
                Console.WriteLine("\nFind not found!");
        }
        public void DeletePhone(int model)
        {
            Console.WriteLine("*****The list before delete: ***** ");
            Show();
            bool find = false;
                foreach (var deletePhone in list)
                {
                    if (deletePhone.Model == model)
                    {
                        list.Remove(deletePhone);
                        find = true;
                        break;
                    }
              

            }
            if (!find) 
                Console.WriteLine("\nNot exit the model that you want to delete!");
            Console.WriteLine("****The list after delete: *****");
            foreach(var deletePhone in list)
            {
                Show();
            }
        }

        public void UpdatePhone()
        {
            Add();
        }
        
    }
}
