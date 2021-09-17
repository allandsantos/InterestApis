using FluentAssertions;
using InterestCalculatorApi.Extensions;
using Xunit;

namespace TestInterestCalculatorApi.ExtensionsTest
{
    public class DecimalExtensionTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1.2, 1, 1.2)]
        [InlineData(1.25, 1, 1.2)]
        [InlineData(1.25, 2, 1.25)]
        [InlineData(1.256, 2, 1.25)]
        public void TruncateTo_ShouldReturnTruncatedValueBasedOnDecimalPlaces(decimal value, int places, decimal result)
        {
            // Act
            var truncatedValue = value.TruncateTo(places);

            // Assert
            truncatedValue.Should().Be(result);
        }
    }
}
