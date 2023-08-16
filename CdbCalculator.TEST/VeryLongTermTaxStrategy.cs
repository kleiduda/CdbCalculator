using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class VeryLongTermTaxStrategyTests
    {
        [Fact]
        public void TestCalculateTaxForGivenYield()
        {
            var taxStrategy = new VeryLongTermTaxStrategy();

            double rendimento = 100;
            double expectedTax = 0.15 * rendimento;

            double actualTax = taxStrategy.CalculateTax(rendimento);

            Assert.Equal(expectedTax, actualTax);
        }
    }
}
