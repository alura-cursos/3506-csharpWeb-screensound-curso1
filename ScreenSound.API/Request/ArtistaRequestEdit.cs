using ScreenSound.API.Request;

namespace ScreenSound.API.Requests;

public record ArtistaRequestEdit(int Id, string nome, string bio)
    : ArtistaRequest(nome, bio);
