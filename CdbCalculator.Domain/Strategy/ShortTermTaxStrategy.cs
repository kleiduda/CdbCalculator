namespace CdbCalculator.Domain.Strategy
{
    public class ShortTermTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double rendimento)
        {
            return 0.225 * rendimento;
        }
    }

}
