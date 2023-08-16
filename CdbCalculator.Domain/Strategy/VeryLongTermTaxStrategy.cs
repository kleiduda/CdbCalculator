namespace CdbCalculator.Domain.Strategy
{
    public class VeryLongTermTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double rendimento)
        {
            return 0.15 * rendimento;
        }
    }

}
