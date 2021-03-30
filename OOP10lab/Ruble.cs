using System;

namespace OOP10lab
{
    public class Ruble : Valuta
    {
        private const double ruble = 5.58; 
        private const double tenge = 0.18;
        private double result;
        
        public override void convertToTenge(double valuta)
        {
            result = valuta * ruble;
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