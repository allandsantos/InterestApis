using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterestRateApi.Controllers
{
    [ApiController]
    public class InterestsController : ControllerBase
    {
        /// <summary>
        /// Obtém a taxa de juros configurada
        /// </summary>
        /// <response code="200">Retorna o valor fixo da taxa</response>
        [HttpGet("taxajuros")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, type: typeof(decimal))]
        public IActionResult GetInterestRate()
        {
            return Ok(InterestRate.Value);
        }
    }
}
