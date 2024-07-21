using ScreenSound.Web.Requests;
using ScreenSound.Web.Response;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services;

public class MusicasAPI
{
    private readonly HttpClient _httpClient;
    public MusicasAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }
    public async Task<MusicaResponse?> GetMusicaPorNomeAsync(string nome)
    {
        return await _httpClient.GetFromJsonAsync<MusicaResponse>($"Musicas/{nome}");
    }
    public async Task<ICollection<MusicaResponse>?> GetMusicasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("Musicas");
    }
    public async Task AddMusicaAsync(MusicaRequest musica)
    {
        await _httpClient.PostAsJsonAsync("Musicas", musica);
    }
    public async Task DeleteMusicaAsync(int id)
    {
        await _httpClient.DeleteAsync($"Musicas/{id}");
    }
    public async Task UpdateMusicaAsync(MusicaRequestEdit artista)
    {
        await _httpClient.PutAsJsonAsync($"Musicas", artista);
    }
}