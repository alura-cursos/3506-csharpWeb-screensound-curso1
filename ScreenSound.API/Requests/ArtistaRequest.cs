using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;
public record ArtistaRequest([Required] string nome, [Required] string bio, string? fotoPerfil);