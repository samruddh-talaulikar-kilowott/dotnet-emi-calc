using Microsoft.AspNetCore.Mvc;
using EMIAPP.Models;
namespace EMIAPP.Controllers
{
    public class ContinuosEmiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContinuosEmi()
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

            double Result = (double)request.Principal * System.Math.Pow(e, ((request.InterestRateInPercentage/100) * request.LoanDurationInYearCount)) ;


            request.Result = Result;
            return View(request);


        }
    }
}
