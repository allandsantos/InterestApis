using Refit;
using System.Threading.Tasks;

namespace InterestCalculatorApi.ExternalServices
{
    public interface IInterestRateApiClient
    {
        [Get("/taxajuros")]
        public Task<decimal> GetInterestRate();
    }
}
