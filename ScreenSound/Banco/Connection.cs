using Microsoft.Data.SqlClient;
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
    }
}
