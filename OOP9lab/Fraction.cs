using System;
using System.Threading.Channels;

namespace OOP9lab
{
    public class Fraction : Pair
    {
        private int n;
        private int d;

        public Fraction(int n, int d)
        {
            
            this.n = n;
            this.d = d;
        }
        public override string ToString()
        {
            return n+"/"+d;
        }


        public override void Compare(Fraction p1)
        {
            
            base.Compare(p1);
            if ((p1.n>n && p1.d == d) || (p1.n == n  && p1.d > d))
            {
                Console.WriteLine(p1+" ulken");
            }else if (p1.n<n && p1.d == d)
            {
                Console.WriteLine(p1+" kishi");
            }
            else
            {
                Console.WriteLine("ten");
            }
        }
    }
}