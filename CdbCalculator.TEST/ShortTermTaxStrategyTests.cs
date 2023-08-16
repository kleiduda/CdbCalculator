using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class ShortTermTaxStrategyTests
    {
        [Fact]
        public void TestCalculateTaxForGivenYield()
        {
            var taxStrategy = new ShortTermTaxStrategy();

            double rendimento = 100;
            double expectedTax = 0.225 * rendimento;

            double actualTax = taxStrategy.CalculateTax(rendimento);

            Assert.Equal(expectedTax, actualTax);
        }
    }
}
