using FluentAssertions;
using InterestCalculatorApi.ExternalServices;
using InterestCalculatorApi.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace TestInterestCalculatorApi.ServiceTest
{
    public class InterestCalculatorServiceTest
    {
        [Theory]
        [InlineData(10, 2, 10.2)]
        [InlineData(20, 4, 20.81)]
        [InlineData(30, 8, 32.48)]
        [InlineData(40, 12, 45.07)]
        public async Task GetTotalInterestRate(decimal valorInicial, int meses, decimal expectedResult)
        {
            // Arrange
            var apiInterestRateClientMock = new Mock<IInterestRateApiClient>();
            apiInterestRateClientMock
                .Setup(x => x.GetInterestRate())
                .Returns(Task.FromResult(0.01m));

            var interestCalculatorService = new InterestCalculatorService(apiInterestRateClientMock.Object);

            // Act
            var interestRate = await interestCalculatorService.GetTotalInterestRate(valorInicial, meses);

            // Assert
            interestRate.Should().Be(expectedResult);
        }
    }
}
