namespace CdbCalculator.Domain.Strategy
{
    public class MidTermTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double rendimento)
        {
            return 0.20 * rendimento;
        }
    }

}
