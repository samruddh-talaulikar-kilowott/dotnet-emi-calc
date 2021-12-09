using Microsoft.AspNetCore.Mvc;
using EMIAPP.Models;
namespace EMIAPP.Controllers
{
    public class DailyEmiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DailyEmi()
        {
            return View();
        }

        public IActionResult Output(double principal, double rate, double duration)
        {
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;
            double e = 2.7183;

            double Result = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 365, 365 * request.LoanDurationInYearCount) -(double)request.Principal;


            request.Result = Result;
            return View(request);


        }

    }
}
