using System;

namespace InterestCalculatorApi.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal TruncateTo(this decimal value, int places)
        {
            var divisor = (decimal) Math.Pow(10, places);
            var truncatedValue = Math.Truncate(divisor * value);

            return truncatedValue / divisor;
        }
    }
}
