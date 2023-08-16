using CdbCalculator.Domain.Entities;

namespace CdbCalculator.Application.Arguments;

public class InvestmentResponse
{
    public double InvestedAmount { get; set; }
    public double Yield { get; set; }
    public double GrossTotal { get; set; }
    public double TaxAmount { get; set; }
    public double NetTotal { get; set; }

    public InvestmentResponse(Investment investment)
    {
        InvestedAmount = investment.InitialValue;
        Yield = investment.Yield;
        GrossTotal = investment.GrossFinalValue;
        TaxAmount = investment.TaxValue;
        NetTotal = investment.NetFinalValue;
    }

}
