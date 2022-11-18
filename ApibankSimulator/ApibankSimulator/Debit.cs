namespace ApibankSimulator
{
    public class Debit
    {
        public double DebitSum { get; set; }
        public double DebitCount { get; set; }
        public double DebitProc { get;  set; }
        /*public  Debit(double _DebitSum, double _DebitCount, double _DebitProc)
        {
            DebitSum = _DebitSum;
            DebitCount = _DebitCount;
            DebitProc = _DebitProc;
        }*/
        public double Total()
        {
            var Total = DebitSum * Math.Pow((1 + (DebitProc /100)), DebitCount);
            return Total;
        }
    }
}
