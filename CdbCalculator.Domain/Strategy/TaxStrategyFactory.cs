using CdbCalculator.Domain.Strategy;

public static class TaxStrategyFactory
{
    public static ITaxStrategy GetTaxStrategy(int periodInMonths)
    {
        if (periodInMonths <= 6)
        {
            return new ShortTermTaxStrategy();
        }
        else if (periodInMonths <= 12)
        {
            return new MidTermTaxStrategy();
        }
        else if (periodInMonths <= 24)
        {
            return new LongTermTaxStrategy();
        }
        else
        {
            return new VeryLongTermTaxStrategy();
        }
    }
}
