using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAl
    {
        public IEnumerable<Artista> Listar()
        {
            var lista = new List<Artista>();
            using var context = new ScreenSoundContext();
           
            return context.Artistas.ToList();
        }
      /*  public void Adicionar(Artista artista)
        {
            using var connection = new ScreenSoundContext().ObterConexao();
            connection.Open();
            string sql = "INSERT INTO Artistas(Nome, FotoPerfil, bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            command.Parameters.AddWithValue("@bio", artista.Bio);
            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas {retorno}");
        }*/
        //public void Atualizar(Artista artista )
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();
        //    string sql = "UPDATE Artistas SET (Nome = @nome, Bio = @bio WHERE Id = @id )";
        //    SqlCommand command = new SqlCommand(sql, connection);



        //}
    }
}
