
using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Domain.Entities;
public class Investment
{
    private readonly ITaxStrategy _taxStrategy;

    public Investment(double initialValue, int periodInMonths, ITaxStrategy taxStrategy)
    {
        InitialValue = initialValue;
        PeriodInMonths = periodInMonths;
        _taxStrategy = taxStrategy;
    }

    public double InitialValue { get; private set; }
    public int PeriodInMonths { get; private set; }
    public double GrossFinalValue { get; private set; }
    public double Yield { get; private set; }
    public double TaxValue { get; private set; }

    public double NetFinalValue => GrossFinalValue - TaxValue;

    public void Calculate()
    {
        double monthlyMultiplier = 1 + (0.009 * 1.08); // 0.9% CDI and 108% TB

        GrossFinalValue = InitialValue;
        for (int i = 0; i < PeriodInMonths; i++)
        {
            GrossFinalValue *= monthlyMultiplier;
        }

        Yield = GrossFinalValue - InitialValue;
        TaxValue = GetTaxValue();
    }
    private double GetTaxValue()
    {
        return _taxStrategy.CalculateTax(Yield);
    }
    
}
