using InterestCalculatorApi.Controllers;
using InterestCalculatorApi.Services.Interfaces;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace TestInterestCalculatorApi.ControllersTest
{
    public class CalculatorControllerTest
    {
        [Fact]
        public async Task CalculateInterest_ShouldCallCalculateInterestFromService()
        {
            // Arrange
            var interestCalculatorServiceMock = new Mock<IInterestCalculatorService>();
            var interetsCalculatorController = new CalculatorController(interestCalculatorServiceMock.Object);

            // Act
            await interetsCalculatorController.GetTotalInterestRate(It.IsAny<decimal>(), It.IsAny<int>());

            // Assert
            interestCalculatorServiceMock.Verify(x => x.GetTotalInterestRate(It.IsAny<decimal>(), It.IsAny<int>()), Times.Once);
        }
    }
}
