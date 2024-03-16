using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;" +
            "Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";

        public SqlConnection ObterConexao ()
        {
            return new SqlConnection (connectionString);
        }

        public IEnumerable<Artista> Listar()
        {
            var lista = new List<Artista>();
            using var connection = ObterConexao();
            connection.Open ();
        }
    }
}
