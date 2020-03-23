using System.Threading.Tasks;
using Refit;
using SiteConsumoAPIContagem.Models;

namespace SiteConsumoAPIContagem.Interfaces
{
    public interface IContagemClient
    {
         [Get("/Contador")]
         Task<ResultadoContador> GetResultado();        
    }
}