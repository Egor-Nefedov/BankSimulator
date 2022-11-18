namespace ApibankSimulator
{
    public class Credit
    {
        public double CreditSum { get; set; }
        public double CreditProc { get; set; }
        public double CreditCount { get; set; }
        public double CreditPay()
        {
            var Pay = CreditSum * (((CreditProc/1200) * Math.Pow((1 +CreditProc/1200), CreditCount*12)) / (Math.Pow((1 + CreditProc/1200), CreditCount * 12)  - 1));
            return Pay;
        }
    }
}
