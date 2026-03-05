using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrimeGorilaDesktop.Services
{
    public class ApiService
    {
        private readonly HttpClient client = new HttpClient();
        private const string API = "http://localhost:5000/api";

        public async Task<dynamic> Login(string email, string senha)
        {
            var json = JsonConvert.SerializeObject(new { email, senha });

            var resp = await client.PostAsync(
                API + "/auth/login",
                new StringContent(json, Encoding.UTF8, "application/json"));

            if (!resp.IsSuccessStatusCode)
                return null;

            var body = await resp.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject(body);
        }
    }
}
