using Previsao_do_Tempo.Models;

namespace Previsao_do_Tempo.Repositorio.Interfaces
{
    public interface ITemperaturaRepositorio
    {
       Task<TemperaturaModel> ObterTemperaturaAsync(string cidade, string pais, string unidadeMedida);
       string MontarParemetrosUrl(string cidade, string pais, string unidadeMedida);
    }
}
