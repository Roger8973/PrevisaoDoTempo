using Previsao_do_Tempo.Models;

namespace Previsao_do_Tempo.Servicos.Interface
{
    public interface ITemperaturaServico
    {
        Task<TemperaturaModel> ObterTemperaturaAsync(string cidade, string pais, string unidadeMedida);
    }
}
