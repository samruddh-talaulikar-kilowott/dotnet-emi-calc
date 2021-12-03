using System;
namespace dotnetemicalc
{
    internal class Program
    {
        internal class Calc
        {
            public double EmiCalculator(double p, double i, double t, double n)
            {
                double emi;
                emi = p * Math.Pow((1 + i / n), (t * n));
                return (emi) / 24;
            }
        }
        static void Main(string[] args)
        {
            var sp = new Calc();
            double p, i, n, t, emi;
            Console.WriteLine("Enter principle:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter interest rate");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter loan duration");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter monthly compounding");
            n = Convert.ToDouble(Console.ReadLine());
            emi = sp.EmiCalculator(p, i, t, n);
            Console.WriteLine("Monthly EMI is: " + Math.Round(emi, 2) + " INR");
        }
    }
}