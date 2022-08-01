using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Previsao_do_Tempo.Repositorio.Interfaces;
using Previsao_do_Tempo.Servicos.Interface;

namespace Previsao_do_Tempo.Controllers
{
    [Route("api/previsao")]
    [ApiController]
    public class PrevisaoController : ControllerBase
    {
        private readonly ITemperaturaServico _servico;

        public PrevisaoController(ITemperaturaServico servico)
        {
            _servico = servico;
        }

        [HttpGet("temperatura")]
        public async Task<IActionResult> ObterTemperatura(string cidade, string pais, string unidadeMedida)
        {
            return Ok(await _servico.ObterTemperaturaAsync(cidade, pais, unidadeMedida));
        }
    }
}
