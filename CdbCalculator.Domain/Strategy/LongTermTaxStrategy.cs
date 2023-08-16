namespace CdbCalculator.Domain.Strategy
{
    public class LongTermTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double rendimento)
        {
            return 0.175 * rendimento;
        }
    }

}
