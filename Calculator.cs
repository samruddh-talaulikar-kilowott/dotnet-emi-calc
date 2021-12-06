namespace EmiApp
{
    public class Calculator: ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            throw new NotImplementedException();
        }

        public Response CalculateDailyEmi(Request request)
        {
            throw new NotImplementedException();
        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 12, power);
                // convert to response object
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }
    }
}