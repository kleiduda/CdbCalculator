using Moq;
using CdbCalculator.Domain.Entities;
using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class InvestmentTests
    {
        [Fact]
        public void TestInvestmentCalculationFor12Months()
        {
            var mockTaxStrategy = new Mock<ITaxStrategy>();
            mockTaxStrategy.Setup(ts => ts.CalculateTax(It.IsAny<double>())).Returns(24.62); 

            var investment = new Investment(1000, 12, mockTaxStrategy.Object);

            investment.Calculate();

            Assert.Equal(1123.08, investment.GrossFinalValue, 2);
            Assert.Equal(123.08, investment.Yield, 2);
            Assert.Equal(24.62, investment.TaxValue, 2);
            Assert.Equal(1098.46, investment.NetFinalValue, 2);
        }

    }
}
