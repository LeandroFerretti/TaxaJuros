using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Constantes;

namespace TaxaJuros.Controllers
{
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        public TaxaJurosController()
        {
        }

        [HttpGet("taxaJuros")]
        public ActionResult<double> BuscarTaxaJuros()
        {
            return Constante.TAXA_DE_JUROS;
        }
    }
}