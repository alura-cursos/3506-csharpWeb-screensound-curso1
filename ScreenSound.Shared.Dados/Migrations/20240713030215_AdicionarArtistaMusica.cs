using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarArtistaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 2 WHERE Id = 3");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 2 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 3 WHERE Id = 5");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 3 WHERE Id = 6");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 4 WHERE Id = 7");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 4 WHERE Id = 8");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 5 WHERE Id = 9");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 5 WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 6 WHERE Id = 11");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 6 WHERE Id = 12");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 7 WHERE Id = 13");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 7 WHERE Id = 14");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 8 WHERE Id = 15");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 8 WHERE Id = 16");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 9 WHERE Id = 17");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 9 WHERE Id = 18");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 10 WHERE Id = 19");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 10 WHERE Id = 20");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 11 WHERE Id = 21");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 11 WHERE Id = 22");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 12 WHERE Id = 23");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 12 WHERE Id = 24");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 13 WHERE Id = 25");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 13 WHERE Id = 26");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 14 WHERE Id = 27");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 14 WHERE Id = 28");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 15 WHERE Id = 29");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 15 WHERE Id = 30");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 16 WHERE Id = 31");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 16 WHERE Id = 32");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 17 WHERE Id = 33");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 17 WHERE Id = 34");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 18 WHERE Id = 35");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 18 WHERE Id = 36");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 19 WHERE Id = 37");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 19 WHERE Id = 38");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 20 WHERE Id = 39");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 20 WHERE Id = 40");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
