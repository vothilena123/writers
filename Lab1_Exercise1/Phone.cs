using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Exercise1
{
    class Phone
    {
        protected int model;
        protected float price;
        protected string brand;
        protected int yearRelease;

        public Phone()
        {

        }

        public Phone(int model, float price, string brand, int yearRelease)
        {
            this.model = model;
            this.price = price;
            this.brand = brand;
            this.yearRelease = yearRelease;
        }

        public void InputInfo()
        {
            Console.WriteLine("Input the model: ");
            model = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Input the price: ");
                price = float.Parse(Console.ReadLine());
            } while (price < 0);
            do
            {
                Console.WriteLine("Input the brand: ");
                brand = Console.ReadLine();
            } while (brand != "LG" && brand != "SamSung" && brand != "Motorola" && brand != "Sony" && brand != "Nokia");
            do
            {
                Console.WriteLine("Input the year release: ");
                yearRelease = int.Parse(Console.ReadLine());
            } while (yearRelease <= 1970 || yearRelease >= 2012);
           
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Year release: " + yearRelease);

        }

        public int Model
        {
            get { return model; }
            set { model = value;}
        }
    }
}
