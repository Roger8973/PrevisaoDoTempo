using Previsao_do_Tempo.Models;
using Previsao_do_Tempo.Repositorio.Interfaces;
using Previsao_do_Tempo.Servicos.Interface;
using System.Text;

namespace Previsao_do_Tempo.Servicos
{
    public class TemperaturaServico : ITemperaturaServico
    {
        private readonly ITemperaturaRepositorio _repositorio;

        public TemperaturaServico(ITemperaturaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<TemperaturaModel> ObterTemperaturaAsync(string cidade, string pais, string unidadeMedida)
        {
            return await _repositorio.ObterTemperaturaAsync(cidade, pais, unidadeMedida);
        }
    }
}
