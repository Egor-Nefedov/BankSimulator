using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApibankSimulator.Controllers
{
    public class BankCreditController : ControllerBase
    {
        [Route("[controller]")]
        [HttpPost]
        public double Credit(Credit credit)
        {
            var CreditSum = credit.CreditSum;
            var CreditCount = credit.CreditCount;
            var CreditProc = credit.CreditProc;
            double Pay = credit.CreditPay();
            return Pay;
        }
    }
}
