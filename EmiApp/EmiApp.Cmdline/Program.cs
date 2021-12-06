using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();

            

            // fill other regions below...

            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly emi is {emiMonthly.EmiPayment}");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);


            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);
            if (string.IsNullOrEmpty (emiDaily.ErrorMessage))
               Console.WriteLine($"Daily emi is {emiDaily.EmiPayment}");
            else
                Console.WriteLine(emiDaily.ErrorMessage);


            var emiContinuous = emiCalculator.CalculateContinousEmi(emiRequest);
            if (string.IsNullOrEmpty(emiContinuous.ErrorMessage))
                Console.WriteLine($"Continuous emi is {Math.Round(emiContinuous.EmiPayment,2)}");
            else
                Console.WriteLine(emiContinuous.ErrorMessage);
        }
    }
}

