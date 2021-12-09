using Microsoft.AspNetCore.Mvc;
using EMIAPP.Models;
namespace EMIAPP.Controllers
{
    public class EmiController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult MonthlyEmi()
        {
            return View();
        }

        public IActionResult Output(double principal, double rate, double duration)
        {

            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;


            double MonthlyEmi = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);
            double e = 2.7183;
            double ContinousEmi = (double)request.Principal * System.Math.Pow(e, (request.InterestRateInPercentage / 100 * request.LoanDurationInYearCount));
            double DailyEmi = ((double)request.Principal * System.Math.Pow(1 + ((request.InterestRateInPercentage / 100) / 365), 365 * request.LoanDurationInYearCount)) - (double)request.Principal;

            request.MonthlyEmi = MonthlyEmi;
            request.ContinousEmi = ContinousEmi;
            request.DailyEmi = DailyEmi;

            return View(request);


        }
    }

}