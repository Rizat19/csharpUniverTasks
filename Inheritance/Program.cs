using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Cylinder(5,"black",7);
            
            Console.WriteLine(c1.getArea());
            //c1.getVolume(); колдана алмаймыз себебі біз Circle объектісін қурдык, ал Circle - parent класс

            Cylinder c2 = new Cylinder(2,"blue", 8);
            Console.WriteLine(c2.getVolume());
            // Cylinder - child-туынды класс, сондықтан ол parent-тегі /базалық/ барлық әдіс/геттер-сеттерге/өрістерді мұралап алады
            Console.WriteLine(c2.getArea());
            Console.WriteLine(c2.Color);
            Console.WriteLine(c2.Radius);
        }
    }
}