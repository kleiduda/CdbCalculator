using CdbCalculator.Application.Arguments;
using Xunit;

namespace CdbCalculator.Tests
{
    public class InvestmentRequestTests
    {
        [Fact]
        public void TestInvestmentRequest_InitialValueLessThanOrEqualToZero()
        {
            var request = new InvestmentRequest(0, 1);

            Assert.False(request.IsValid);
            Assert.Contains(request.Notifications, n => n.Message.Contains("Valor inicial não pode ser igual a zero."));
        }

        [Fact]
        public void TestInvestmentRequest_PeriodInMonthsLessThanOrEqualToZero()
        {
            var request = new InvestmentRequest(100, 0);

            Assert.False(request.IsValid);
            Assert.Contains(request.Notifications, n => n.Message.Contains("Período em meses não pode ser igual a zero."));
        }

        [Fact]
        public void TestInvestmentRequest_ValidValues()
        {
            var request = new InvestmentRequest(100, 1);

            Assert.True(request.IsValid);
            Assert.Empty(request.Notifications);
        }
    }
}
