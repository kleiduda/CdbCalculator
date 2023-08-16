using Moq;
using CdbCalculator.Domain.Entities;
using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class InvestmentTests
    {
        [Fact]
        public void TestInvestmentCalculationFor6Months()
        {
            var mockTaxStrategy = new Mock<ITaxStrategy>();
            mockTaxStrategy.Setup(ts => ts.CalculateTax(It.IsAny<double>())).Returns(13.44);

            var investment = new Investment(1000, 6, mockTaxStrategy.Object);

            investment.Calculate();

            Assert.Equal(1059.76, investment.GrossFinalValue, 2);
            Assert.Equal(59.76, investment.Yield, 2);
            Assert.Equal(13.44, investment.TaxValue, 2);
            Assert.Equal(1046.32, investment.NetFinalValue, 2);
        }

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

        [Fact]
        public void TestInvestmentCalculationFor24Months()
        {
            var mockTaxStrategy = new Mock<ITaxStrategy>();
            mockTaxStrategy.Setup(ts => ts.CalculateTax(It.IsAny<double>())).Returns(45.73);

            var investment = new Investment(1000, 24, mockTaxStrategy.Object);

            investment.Calculate();

            Assert.Equal(1261.31, investment.GrossFinalValue, 2);
            Assert.Equal(261.31, investment.Yield, 2);
            Assert.Equal(45.73, investment.TaxValue, 2);
            Assert.Equal(1215.58, investment.NetFinalValue, 2);
        }

        [Fact]
        public void TestInvestmentCalculationFor36Months()
        {
            var mockTaxStrategy = new Mock<ITaxStrategy>();
            mockTaxStrategy.Setup(ts => ts.CalculateTax(It.IsAny<double>())).Returns(62.48);

            var investment = new Investment(1000, 36, mockTaxStrategy.Object);

            investment.Calculate();

            Assert.Equal(1416.56, investment.GrossFinalValue, 2);
            Assert.Equal(416.56, investment.Yield, 2);
            Assert.Equal(62.48, investment.TaxValue, 2);
            Assert.Equal(1354.08, investment.NetFinalValue, 2);
        }
    }
}
