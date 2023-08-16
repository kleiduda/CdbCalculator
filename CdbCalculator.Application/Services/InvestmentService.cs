using CdbCalculator.Application.Arguments;
using CdbCalculator.Domain.Entities;

namespace CdbCalculator.Application.Services;
public class InvestmentService
{
    public ServiceResult<InvestmentResponse> Calculate(InvestmentRequest request)
    {
        ServiceResult<InvestmentResponse> serviceResult = new ServiceResult<InvestmentResponse>();
        try
        {
            if (request.IsValid)
            {
                var taxStrategy = TaxStrategyFactory.GetTaxStrategy(request.PeriodInMonths);
                var investment = new Investment(request.InitialValue, request.PeriodInMonths, taxStrategy);
                investment.Calculate();

                serviceResult.Result = new InvestmentResponse(investment);
            }
            else
            {
                serviceResult.Mensagens = request.Notifications.Select(x => x.Message).ToList();
            }
            

        }
        catch (Exception ex)
        {
            serviceResult.Status = false;
            serviceResult.Error = ex.Message;
            serviceResult.Mensagens = new List<string>() { "Erro ao realizar calculo"};
        }

        return serviceResult;
    }
}
