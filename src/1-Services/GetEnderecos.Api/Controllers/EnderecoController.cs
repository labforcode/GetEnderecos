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
        [Route("endereco/cep/{cep}")]
        public async Task<EnderecoViewModel> ObterEnderecoPorCep(string cep)
        {
            return await _enderecoService.ObterEnderecoPorCep(cep);
        }

        [HttpGet]
        [Route("enderecos/logradouro/{logradouro}/municipio/{municipio}/uf/{uf}")]
        public async Task<IEnumerable<EnderecoViewModel>> ObterEnderecos(string logradouro, string municipio, string uf)
        {
            return await _enderecoService.ObterEnderecos(logradouro, municipio, uf);
        }

        [HttpGet]
        [Route("enderecos")]
        public async Task<IEnumerable<EnderecoViewModel>> ObterTodosEnderecos()
        {
            return await _enderecoService.ObterTodosEnderecos();
        }
    }
}