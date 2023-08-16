using Flunt.Notifications;
using Flunt.Validations;

namespace CdbCalculator.Application.Arguments;
public class InvestmentRequest : Notifiable<Notification>
{
    public InvestmentRequest(double initialValue, int periodInMonths)
    {
        InitialValue = initialValue;
        PeriodInMonths = periodInMonths;

        AddNotifications(new Contract<InvestmentRequest>()
               .IsGreaterThan(initialValue, 0, "InitialValue", "Valor inicial não pode ser igual a zero.")
               .IsGreaterThan(periodInMonths, 0, "PeriodInMonths", "Período em meses não pode ser igual a zero.")
        );
    }

    public double InitialValue { get; private set; }
    public int PeriodInMonths { get; private set; }
}

