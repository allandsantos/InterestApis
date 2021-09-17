using InterestCalculatorApi.Extensions;
using InterestCalculatorApi.ExternalServices;
using InterestCalculatorApi.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace InterestCalculatorApi.Services
{
    public class InterestCalculatorService : IInterestCalculatorService
    {
        private readonly IInterestRateApiClient _apiJurosClient;

        public InterestCalculatorService(IInterestRateApiClient apiJurosClient)
        {
            _apiJurosClient = apiJurosClient;
        }

        public async Task<decimal> GetTotalInterestRate(decimal valorInicial, int meses)
        {
            var currentRate = await _apiJurosClient.GetInterestRate();
            var totalRate =
                valorInicial * (decimal) Math.Pow((double)(1 + currentRate), meses);

            return totalRate.TruncateTo(places: 2);
        }
    }
}
