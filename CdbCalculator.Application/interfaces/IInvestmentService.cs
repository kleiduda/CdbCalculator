using CdbCalculator.Application.Arguments;

namespace CdbCalculator.Application.interfaces
{
    public interface IInvestmentService
    {
        ServiceResult<InvestmentResponse> Calculate(InvestmentRequest request);
    }
}
