using System;

namespace OOP9lab
{
    public class Pair
    {
        protected int p1;
        protected int p2;

        public Pair()
        {
            p1 = 1;
            p2 = 10;
        }
        
        public Pair(int p1, int p2)
        {
            
            this.p1 = p1;
            this.p2 = p2;
        }
        
        
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        
        public int P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public void manOzgertu(int n1, int n2)
        {
            this.p1 += n1;
            this.p2 += n2;
        }
        
        public void manOzgertu(int n)
        {
            this.p1 *= n;
            this.p2 *= n;
        }
        
        // логический оператор > <
        public static bool operator >(Pair obj1, Pair obj2)
        {
            if (obj1.p1 > obj2.p1  && obj1.p2 == obj2.p2 ) {return true;}
            else if (obj1.p1 == obj2.p1  && obj1.p2 > obj2.p2 ) {return true;}
            
            return false;
        }

        public static bool operator <(Pair obj1, Pair obj2)
        {
            if (obj1.p1 < obj2.p1  && obj1.p2 == obj2.p2 ) {return true;}
            return false;
        }

        public virtual void Compare(Fraction p1)
        {
            Console.WriteLine("2 объектини салыстыру");
        }

        public override string ToString()
        {
            return $"({p1};{p2})";
        }
    }
}