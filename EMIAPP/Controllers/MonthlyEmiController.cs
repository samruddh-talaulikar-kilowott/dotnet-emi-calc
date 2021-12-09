using Microsoft.AspNetCore.Mvc;
using EMIAPP.Models;
namespace EMIAPP.Controllers
{
    public class MonthlyEmiController : Controller
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


            double Result = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);


            request.Result = Result;
            return View(request);


        }
    }
}