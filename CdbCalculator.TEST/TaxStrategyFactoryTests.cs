using CdbCalculator.Domain.Strategy;

namespace CdbCalculator.Tests
{
    public class TaxStrategyFactoryTests
    {
        [Theory]
        [InlineData(1, typeof(ShortTermTaxStrategy))]
        [InlineData(6, typeof(ShortTermTaxStrategy))]
        [InlineData(7, typeof(MidTermTaxStrategy))]
        [InlineData(12, typeof(MidTermTaxStrategy))]
        [InlineData(13, typeof(LongTermTaxStrategy))]
        [InlineData(24, typeof(LongTermTaxStrategy))]
        [InlineData(25, typeof(VeryLongTermTaxStrategy))]
        [InlineData(36, typeof(VeryLongTermTaxStrategy))]
        public void GetTaxStrategy_ReturnsCorrectStrategy(int periodInMonths, Type expectedStrategyType)
        {
            var strategy = TaxStrategyFactory.GetTaxStrategy(periodInMonths);

            Assert.IsType(expectedStrategyType, strategy);
        }
    }
}
