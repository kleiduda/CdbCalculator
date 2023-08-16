using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class MidTermTaxStrategyTests
    {
        [Fact]
        public void TestCalculateTaxForGivenYield()
        {
            var taxStrategy = new MidTermTaxStrategy();

            double rendimento = 100;
            double expectedTax = 0.20 * rendimento;

            double actualTax = taxStrategy.CalculateTax(rendimento);

            Assert.Equal(expectedTax, actualTax);
        }
    }
}
