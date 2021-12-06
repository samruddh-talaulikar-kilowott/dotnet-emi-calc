using System;
namespace dotnetemicalc
{
    internal class Program
    { 
        public static void Main(string[] args)
        {
            double p, i, n, t, emi;
            var sp = new EmiCalculator();
            try
            {
                Console.WriteLine("Enter principle:");
                p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter interest rate");
                i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter loan duration");
                t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter monthly compounding");
                n = Convert.ToDouble(Console.ReadLine());
                emi = sp.CalculateEmi(p, i, t, n);
                Console.WriteLine("Monthly EMI is: " + Math.Round(emi, 2) + " INR");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input!");
            }
            /*
            finally
            {
                Console.WriteLine("EndOfCode");
            }
            */
        }
    }
}