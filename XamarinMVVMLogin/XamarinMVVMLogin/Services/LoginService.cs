using System.Net.Http;
using System.Threading.Tasks;

namespace XamarinMVVMLogin.Services
{
    public class LoginService
    {
        public async Task<bool> LoginAsync(string login, string password)
        {
            var content = "";
            bool str = true;
            var client = new HttpClient();
            string conexao = $"http://192.168.25.9/WebTeste/api/usuario/GetReturnUser/{login}/{password}";
            var result = await client.GetAsync(conexao);
            content = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                if (content.Equals("false")) str = false;
            }
            return str;
        }
    }
}
