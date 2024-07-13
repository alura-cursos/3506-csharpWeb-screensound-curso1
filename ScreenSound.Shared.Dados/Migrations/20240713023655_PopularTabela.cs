using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas",
                 new string[] { "Nome", "Bio", "FotoPerfil" },
                 new object[] { "Queen", "Banda britânica de rock formada em 1970.", "www.queen.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "The Beatles", "Banda britânica de rock formada em 1960.", "www.thebeatles.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Led Zeppelin", "Banda britânica de rock formada em 1968.", "www.ledzeppelin.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Pink Floyd", "Banda britânica de rock formada em 1965.", "www.pinkfloyd.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "The Rolling Stones", "Banda britânica de rock formada em 1962.", "www.rollingstones.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "AC/DC", "Banda australiana de rock formada em 1973.", "www.acdc.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Nirvana", "Banda americana de rock formada em 1987.", "www.nirvana.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Metallica", "Banda americana de heavy metal formada em 1981.", "www.metallica.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Guns N' Roses", "Banda americana de hard rock formada em 1985.", "www.gunsnroses.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Aerosmith", "Banda americana de rock formada em 1970.", "www.aerosmith.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "U2", "Banda irlandesa de rock formada em 1976.", "www.u2.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Pearl Jam", "Banda americana de rock formada em 1990.", "www.pearljam.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Red Hot Chili Peppers", "Banda americana de rock formada em 1983.", "www.redhotchilipeppers.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Coldplay", "Banda britânica de rock formada em 1996.", "www.coldplay.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Foo Fighters", "Banda americana de rock formada em 1994.", "www.foofighters.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Green Day", "Banda americana de punk rock formada em 1987.", "www.greenday.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Linkin Park", "Banda americana de rock formada em 1996.", "www.linkinpark.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Radiohead", "Banda britânica de rock formada em 1985.", "www.radiohead.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "The Strokes", "Banda americana de rock formada em 1998.", "www.thestrokes.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Oasis", "Banda britânica de rock formada em 1991.", "www.oasis.com" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
