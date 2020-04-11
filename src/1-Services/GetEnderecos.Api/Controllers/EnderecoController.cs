using GetEnderecos.Application.Interfaces.Enderecos;
using GetEnderecos.Application.ViewModels.Enderecos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GetEnderecos.Api.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }


        [HttpGet]
        [Route("enderecos")]
        public async Task<EnderecoViewModel> ObterEnderecos()
        {

            return null;
        }
    }
}