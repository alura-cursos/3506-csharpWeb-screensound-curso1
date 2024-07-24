namespace ScreenSound.Web.Response;

public record ArtistaResponse(int Id, string Nome, string Bio, string? FotoPerfil)
{
    public double? Classificacao { get; set; }
};