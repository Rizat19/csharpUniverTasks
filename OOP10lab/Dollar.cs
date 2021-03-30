using System;

namespace OOP10lab
{
    public class Dollar : Valuta
    {
        private const double dollar = 425.04;
        private const double tenge = 0.0024;
        private double result;

        public override void convertToTenge(double valuta)
        {
            result = valuta * dollar;
        }

        public override void convertFromTenge(double valuta)
        {
            result = valuta * tenge;
        }

        public override void displayPrint()
        {
            
            Console.WriteLine($"valuta convert result : {result}");
        }
    }
}