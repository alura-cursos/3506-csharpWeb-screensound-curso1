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
        return await _httpClient.GetFromJsonAsync<MusicaResponse>($"musicas/{nome}");
    }
    public async Task<IEnumerable<MusicaResponse>> GetMusicasPorGeneroAsync(string genero)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MusicaResponse>>($"musicas/porGenero/{genero}");
    }

    public async Task<ICollection<MusicaResponse>?> GetMusicasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("musicas");
    }
    public async Task AddMusicaAsync(MusicaRequest musica)
    {
        await _httpClient.PostAsJsonAsync("musicas", musica);
    }
    public async Task DeleteMusicaAsync(int id)
    {
        await _httpClient.DeleteAsync($"musicas/{id}");
    }
    public async Task UpdateMusicaAsync(MusicaRequestEdit artista)
    {
        await _httpClient.PutAsJsonAsync($"musicas", artista);
    }
}