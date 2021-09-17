using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    public class SourceCodeController : ControllerBase
    {
        /// <summary>
        /// Obtém a url do repositório GitHub que contém o código fonte deste projeto
        /// </summary>
        /// <response code="200">Retorna a url do repositório GitHub</response>
        [HttpGet("showmethecode")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, type: typeof(string))]
        public IActionResult GetSourceCodeUrl()
        {
            return Ok(SourceCode.GitHubRepoUrl);
        }
    }
}
