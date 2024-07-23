using Microsoft.AspNetCore.Components.Authorization;
using ScreenSound.Web.Response;
using System.Net.Http.Json;
using System.Security.Claims;

namespace ScreenSound.Web.Services
{
    public class AuthAPI(IHttpClientFactory factory) : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient = factory.CreateClient("API");

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var pessoa = new ClaimsPrincipal();
            var response = await _httpClient.GetAsync("auth/manage/info");

            if(response.IsSuccessStatusCode)
            {
                var info = await response.Content.ReadFromJsonAsync<InfoPessoaResponse>();
                Claim[] dados =
                    [
                    new Claim(ClaimTypes.Name, info.Email),
                    new Claim(ClaimTypes.Email, info.Email)

                    ];

                var identity = new ClaimsIdentity(dados, "Cookies");
                pessoa = new ClaimsPrincipal(identity);
            }

            return new AuthenticationState(pessoa);
        }

        public async Task<AuthResponse> LoginAsync(string email, string senha)
        {
            var response = await _httpClient.PostAsJsonAsync("auth/login?useCookies=true", new
            {
                email,
                password = senha
            });

            if (response.IsSuccessStatusCode)
            {
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return new AuthResponse { Sucesso = true };
            }

            return new AuthResponse { Sucesso = false, Erros = ["Login/senha inválidos"] };
        }
    }
}
