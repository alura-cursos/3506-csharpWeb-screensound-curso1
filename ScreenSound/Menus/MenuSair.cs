using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(ArtistaDAL artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
