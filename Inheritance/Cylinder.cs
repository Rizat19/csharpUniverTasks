using System;

namespace Inheritance
{
    public class Cylinder : Circle
    {
        private double height = 1.0;

        public Cylinder(double radius, string color,double heght) : base(radius,color)
        {
            this.height = heght;
        }
        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double getVolume()
        {
            return 2 * Math.PI * this.radius * height; // protected - модификатор доступ койса, сол өріс мураланган класста
        }                                               //колданса болады, егер private десек тек сол класс ішінде гана колданылады
    }
}