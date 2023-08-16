using CdbCalculator.Application;

namespace CdbCalculator.Tests
{
    public class ServiceResultTests
    {
        [Fact]
        public void TestStatusTrueWhenNoErrorAndResultNotNull()
        {
            var serviceResult = new ServiceResult<string>
            {
                Result = "teste calculadora cdb"
            };

            Assert.True(serviceResult.Status);
        }

        [Fact]
        public void TestStatusFalseWhenThereIsAnError()
        {
            var serviceResult = new ServiceResult<string>
            {
                Result = "teste calculadora cdb",
                Error = "Falhou algo"
            };

            Assert.False(serviceResult.Status);
        }

        [Fact]
        public void TestStatusFalseWhenResultIsNull()
        {
            var serviceResult = new ServiceResult<string>();

            Assert.False(serviceResult.Status);
        }

        [Fact]
        public void TestStatusFalseWhenStatusExplicitlySetToFalse()
        {
            var serviceResult = new ServiceResult<string>
            {
                Result = "teste calculadora cdb",
                Status = false
            };

            Assert.False(serviceResult.Status);
        }
    }
}
