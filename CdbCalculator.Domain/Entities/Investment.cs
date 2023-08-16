
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

    public Investment(double initialValue, int periodInMonths)
    {
        InitialValue = initialValue;
        PeriodInMonths = periodInMonths;
    }

    public void Calculate()
    {
        double monthlyMultiplier = 1 + (0.009 * 1.08); // 0.9% CDI and 108% TB

        GrossFinalValue = InitialValue;
        for (int i = 0; i < PeriodInMonths; i++)
        {
            GrossFinalValue *= monthlyMultiplier;
            //GrossFinalValue = Math.Round(GrossFinalValue, 2);
            //GrossFinalValue = GrossFinalValue;
        }

        Yield = GrossFinalValue - InitialValue;
        TaxValue = GetTaxValue();
    }
    private double GetTaxValue()
    {
        return _taxStrategy.CalculateTax(Yield);
    }
    
    //metodo sem o uso do padrao strategy, mantive aqui para mostrar como o padrao de strategy ajuda com Principio SOLID "open closed"
    //private double GetTaxValue()
    //{
    //    double taxRate = 0;

    //    if (PeriodInMonths <= 6) taxRate = 0.225;
    //    else if (PeriodInMonths <= 12) taxRate = 0.20;
    //    else if (PeriodInMonths <= 24) taxRate = 0.175;
    //    else taxRate = 0.15;

    //    return Rendimento * taxRate;
    //}
}
