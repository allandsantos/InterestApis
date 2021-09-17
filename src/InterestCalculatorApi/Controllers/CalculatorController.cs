using InterestCalculatorApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IInterestCalculatorService _interestCalculatorService;

        public CalculatorController(IInterestCalculatorService interestCalculatorService)
        {
            _interestCalculatorService = interestCalculatorService;
        }

        /// <summary>
        /// Calcula o valor total sobre as taxas de juros
        /// </summary>
        /// <param name="valorInicial">Valor inicial sem as taxas</param>
        /// <param name="meses">Quantidade de meses para calculo</param>
        /// <response code="200">Retorna o valor total calculado</response>
        [HttpGet("calculajuros")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, type: typeof(decimal))]
        public async Task<IActionResult> GetTotalInterestRate([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            var result = await _interestCalculatorService.GetTotalInterestRate(valorInicial, meses);
            return Ok(result);
        }
    }
}
