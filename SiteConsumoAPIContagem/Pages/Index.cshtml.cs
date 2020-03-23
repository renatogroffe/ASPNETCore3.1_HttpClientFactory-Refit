using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SiteConsumoAPIContagem.Interfaces;

namespace SiteConsumoAPIContagem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]IContagemClient contagemClient)
        {
            var resultado = contagemClient.GetResultado().Result;
            TempData["ValorContador"] = resultado.ValorAtual;
            TempData["ResultadoAPIContagem"] =
                JsonSerializer.Serialize(resultado);
        }
    }
}