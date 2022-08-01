using Newtonsoft.Json;
using Previsao_do_Tempo.Models;
using Previsao_do_Tempo.Repositorio.Interfaces;
using Previsao_do_Tempo.Utils;
using System.Text;

namespace Previsao_do_Tempo.Repositorio
{
    public class TemperaturaRepositorio : ITemperaturaRepositorio
    {
        private readonly HttpClientExtensions _htpp;
        private readonly TemperaturaModel _tempModel;

        public TemperaturaRepositorio(HttpClientExtensions htpp, TemperaturaModel tempModel)
        {
            _htpp = htpp;
            _tempModel = tempModel;
        }

        public async Task<TemperaturaModel> ObterTemperaturaAsync(string cidade, string pais, string unidadeMedida)
        {
            var cliente = _htpp.Url();
            var urlParametros = MontarParemetrosUrl(cidade, pais, unidadeMedida);

            HttpResponseMessage response = await cliente.GetAsync(urlParametros);

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                Root classePadrao = JsonConvert.DeserializeObject<Root>(dados);
                _tempModel.TemperaturaAtual = classePadrao.Main.Temp;

                return _tempModel;
            }
            return null;
        }

        public string MontarParemetrosUrl(string cidade, string pais, string unidadeMedida)
        {
            var apiKey = "187782ada2364129411f9f4c56bd7aa3";
            var url = new StringBuilder();

            url.AppendFormat(@"?q={0},{1}&APPID={2}&units={3}", cidade, pais, apiKey, unidadeMedida);

            return url.ToString();
        }


    }
}
