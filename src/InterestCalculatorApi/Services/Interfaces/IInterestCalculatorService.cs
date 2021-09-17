using System.Threading.Tasks;

namespace InterestCalculatorApi.Services.Interfaces
{
    public interface IInterestCalculatorService
    {
        Task<decimal> GetTotalInterestRate(decimal valorInicial, int meses);
    }
}
