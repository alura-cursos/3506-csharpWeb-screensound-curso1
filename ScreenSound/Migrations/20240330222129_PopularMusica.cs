using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Oceano", 1989 });

            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Flor de Lis", 1976 });

            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Samurai", 1982 });

            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Se", 1992 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
