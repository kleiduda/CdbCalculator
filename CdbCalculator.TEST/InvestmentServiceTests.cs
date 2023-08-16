using CdbCalculator.Application.Services;
using CdbCalculator.Application.Arguments;

namespace CdbCalculator.Tests.Application.Services
{
    public class InvestmentServiceTests
    {
        [Fact]
        public void Calculate_WithValidRequest_ShouldReturnValidResponse()
        {
            var investmentRequest = new InvestmentRequest(1000, 12);
            var service = new InvestmentService();

            var result = service.Calculate(investmentRequest);

            Assert.True(result.Status);  
            Assert.NotNull(result.Result);
            Assert.Equal(1000, result.Result.InvestedAmount);
        }

        [Fact]
        public void Calculate_WithInvalidRequest_ShouldReturnErrorMessages()
        {
            var investmentRequest = new InvestmentRequest(0, 0); 
            var service = new InvestmentService();

            var result = service.Calculate(investmentRequest);

            Assert.False(result.Status);
            Assert.True(result.Mensagens.Any());
        }

    }
}
