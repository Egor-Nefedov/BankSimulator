using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApibankSimulator.Controllers
{
    public class BankDebitController : ControllerBase
    {
        [Route("[controller]")]
        [HttpPost]
        public double Debit( Debit debit)
        {
            var DebitSum = debit.DebitSum;
            var DebitCount = debit.DebitCount;  
            var DebitProc = debit.DebitProc;
            double Total = debit.Total();
            return Total;
        }
       
    }
}
