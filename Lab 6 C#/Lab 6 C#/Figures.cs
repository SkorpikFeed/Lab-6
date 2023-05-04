using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_C_
{
    public interface ICalculatingFigureProperties
    {
        double Perimeter { get; set; }
        public double SideArea();
        public double Volume();
    }
    internal class RightPyramid : ICalculatingFigureProperties
    {
        private double height;
        private double side;
        private double perimeter;
        public double Perimeter 
        { 
            get { return perimeter; }
            set { perimeter = value; } 
        }
        public RightPyramid(double height, double side, double perimeter)
        {
            this.height = height;
            this.side = side;
            this.perimeter = perimeter;
        }
        public double SideArea()
        {
            Console.WriteLine("Enter the number of sides of the pyramid: ");
            int sides = Convert.ToInt32(Console.ReadLine());
            perimeter = (side * sides);
            double r = side/(2*Math.Tan(180/sides));
            double l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(height, 2));
            return Math.Round(perimeter/2 * l);
        }
        public double Volume()
        {
            Console.WriteLine("Enter the number of sides of the pyramid: ");
            int sides = Convert.ToInt32(Console.ReadLine());
            double S = (sides*Math.Pow(side, 2))/(4*Math.Tan(180/sides));
            return Math.Round( S * height / 3);
        }
    }
    internal class Cone : ICalculatingFigureProperties
    {
        private double height;
        private double radius;
        private double perimeter;
        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        public Cone(double height, double radius, double perimeter)
        {
            this.height = height;
            this.radius = radius;
            this.perimeter = perimeter;
        }
        public double SideArea()
        {
            perimeter = (radius * 2* Math.PI);
            double l = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.Round(perimeter / 2 * l);
        }
        public double Volume()
        {
            return Math.Round(Math.PI* Math.Pow(radius, 2) * height / 3);
        }
    }
}
