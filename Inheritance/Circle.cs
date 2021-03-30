using System;

namespace Inheritance
{
    public class Circle
    {
        protected double radius = 1.0;
        private string color = "red";

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        
        public string Color
        { 
            get { return color; }
            set { color = value; }
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle[radius = {radius}, color: {color}]";
        }
    }
}