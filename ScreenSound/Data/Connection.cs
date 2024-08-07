using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Data
{
      class Connection
    {
        private string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ScreenSounds;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public IEnumerable<Artista> ListArtists()
        {
            var list = new List<Artista>();
            using var connection = GetConnection();
            connection.Open();

            string sql = "SELECT * FROM Artists";
            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string ArtistName = Convert.ToString(dataReader["Name"]);
                string bioArtist = Convert.ToString(dataReader["Bio"]);
                int ArtistId = Convert.ToInt32(dataReader["Id"]);
                Artista artist = new(ArtistName, bioArtist) { Id = ArtistId };

                list.Add(artist);
            }
            return list;
        }
    }
}
