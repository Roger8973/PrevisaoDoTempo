using System.Net.Http.Headers;

namespace Previsao_do_Tempo.Utils
{
    public class HttpClientExtensions
    {
        public HttpClient Url()
        {
            var cliente = new HttpClient();

            cliente.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather/");

            return cliente;
        }
    }
}
