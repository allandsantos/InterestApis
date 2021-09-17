using FluentAssertions;
using InterestRateApi;
using InterestRateApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestInterestRateApi.ControllersTest
{
    public class InterestsControllerTest
    {
        [Fact]
        public void GetInterestRate_ShouldReturnOnePercentInDecimal()
        {
            // Arrange
            var interestController = new InterestsController();

            // Act
            var result = (OkObjectResult)interestController.GetInterestRate();

            // Assert
            result.Value
                .Should().Be(InterestRate.Value);
        }
    }
}
