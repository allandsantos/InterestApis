using FluentAssertions;
using InterestCalculatorApi;
using InterestCalculatorApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestInterestCalculatorApi.ControllersTest
{
    public class SourceCodeControllerTest
    {
        [Fact]

        public void GetSourceCodeUrl()
        {
            // Arrange
            var showCodeController = new SourceCodeController();

            // Act
            var result = (OkObjectResult) showCodeController.GetSourceCodeUrl();

            // Assert
            result.Value
                .Should().Be(SourceCode.GitHubRepoUrl);
        }
    }
}
