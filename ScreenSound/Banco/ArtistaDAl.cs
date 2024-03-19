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
        public void Adicionar(Artista artista)
        {
            using var context = new ScreenSoundContext();
            context.Artistas.Add(artista);
            context.SaveChanges();
        }
        //public void Atualizar(Artista artista )
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();
        //    string sql = "UPDATE Artistas SET (Nome = @nome, Bio = @bio WHERE Id = @id )";
        //    SqlCommand command = new SqlCommand(sql, connection);



        //}
    }
}
