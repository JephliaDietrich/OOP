using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Flower
    {

        private string name;
        private string type;
        private double cost;
        private double hight;

        public Flower()
        {
            name = "";
            type = "";
            cost = 0;
            hight = 0;
        }


        public string Name
        {
            get { return name; }

            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The name cannot be empty.");
                    name = "nothing";
                }
                else
                {
                    name = value;
                }

            }


        }


        public string Type
        {
            get { return type; }

            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The type cannot be empty.");
                    type = "nothing";
                }
                else
                {
                    type = value;
                }

            }

        }


        public double Cost
        {
            get { return cost; }
            set
            {

                if (value < 0)
                {
                    Console.WriteLine($"Cost cannot be negative.");
                    cost = 0;
                }
                else
                {
                    cost = value;
                }

            }
        }


        public double Hight
        {
            get { return hight; }
            set { 
            
                if( value < 0)
                {
                    Console.WriteLine($"Hight cannot be negative.");
                    hight = 0;
                }
                else
                {
                    hight = value;
                }
            
            }
        }


        public void EditFlower()
        {


            Console.WriteLine();
            Console.Write($"Name: ");
            string? nameFlower = Console.ReadLine();
            this.Name = nameFlower;


            Console.WriteLine();
            Console.Write($"Type: ");
            string? typeFlower = Console.ReadLine();
            this.Type = typeFlower;

            Console.WriteLine();
            Console.Write($"Cost: ");
            string? costFlower = Console.ReadLine();
            double cost1 = double.Parse(costFlower);
            this.Cost = cost1;


            Console.WriteLine();
            Console.Write($"Hight: ");
            string? hightFlower = Console.ReadLine();
            double hight1 = double.Parse(hightFlower);
            this.Hight = hight1;

        }


        public void GetFlowerInfo()
        {
            Console.WriteLine($"Your flower has the following updated parameters: name - {Name}, type - {Type}, cost - {Cost}, hight - {Hight}.");
        }


        public string AnalysHight()
        {
            if(hight < 50)
            {
                return "A small plant. Its height = " + hight;
            } else if(hight > 150)
            {
                return "A tall plant. Its height = " + hight;
            }
            else
            {
                return "An average plant. Its height = " + hight;
            }
        }



    }
}
