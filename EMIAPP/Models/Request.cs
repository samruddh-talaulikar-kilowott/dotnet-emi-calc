namespace EMIAPP.Models
{
    public class Request
    {
        public double Principal { internal get; set; }
        public double InterestRateInPercentage { internal get; set; }
        public double LoanDurationInYearCount { internal get; set; }
        public double Result { internal get; set; }
    }
}
