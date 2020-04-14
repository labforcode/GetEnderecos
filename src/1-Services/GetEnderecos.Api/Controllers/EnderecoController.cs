using GetEnderecos.Application.Interfaces.Enderecos;
using GetEnderecos.Application.ViewModels.Enderecos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<IEnumerable<EnderecoViewModel>> ObterEnderecos()
        {
            return await _enderecoService.ObterTodos();
        }
    }
}