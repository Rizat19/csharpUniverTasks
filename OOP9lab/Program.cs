using System;

namespace OOP9lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair p1 = new Pair(2, 5);
            Pair p2 = new Pair(7, 5);
            
            Fraction f1 = new Fraction(6, 19);
            Fraction f2 = new Fraction(3, 19);

            Console.WriteLine("birinshi obj "+f1);
            Console.WriteLine("ekinshi obj "+f2+"\n");
            
            if (p1 > p2)
            {
                Console.WriteLine(p1 +" ulken");
            }
            else if (p1 < p2)
            {
                Console.WriteLine(p2 +" ulken");
            }
            
            f1.Compare(f2);


        }
    }
}