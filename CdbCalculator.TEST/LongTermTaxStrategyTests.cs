using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class LongTermTaxStrategyTests
    {
        [Fact]
        public void TestCalculateTaxForGivenYield()
        {
            var taxStrategy = new LongTermTaxStrategy();

            double rendimento = 100; 
            double expectedTax = 0.175 * rendimento;

            double actualTax = taxStrategy.CalculateTax(rendimento);

            Assert.Equal(expectedTax, actualTax);
        }
    }
}
