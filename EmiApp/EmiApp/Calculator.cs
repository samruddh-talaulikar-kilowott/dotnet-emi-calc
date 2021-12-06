namespace EmiApp
{
    public class Calculator : ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            //start:)
            var response = new Response();
            try
            {
                var a = request.Principal;
                var b = request.LoanDurationInYearCount;
                var c = request.InterestRateInPercentage/100;
                double e = 2.7183;
                var d = (double)a * Math.Pow(e, (c * b));
                response.EmiPayment = (decimal)d;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            return response;
            //end:)
            throw new NotImplementedException();
        }

        public Response CalculateDailyEmi(Request request)
        {
            //start:)
            var response = new Response();
            try
            {
                var a = request.Principal;
                var b = request.LoanDurationInYearCount;
                var c = request.InterestRateInPercentage/100;
                double e = 2.7183;
                var d = (double)a * Math.Pow(1 + (c / 365), 365 * b) -(double)a;
                response.EmiPayment = (decimal)d;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            return response;
            //end:)
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
                response.EmiPayment = (decimal)accumulated;
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