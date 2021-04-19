using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TaxaJuros.Controllers
{
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TaxaJurosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("taxaJuros")]
        public ActionResult<double> BuscarTaxaJuros()
        {
            return _configuration.GetSection("TaxaJuros").Get<double>();
        }
    }
}