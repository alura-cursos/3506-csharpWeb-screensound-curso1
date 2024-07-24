using ScreenSound.Web.Response;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services;

public class MusicaAPI
{
    private readonly HttpClient _httpClient;
    public MusicaAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<MusicaResponse>?> GetMusicasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("musicas");
    }
}