using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MusicaAi.DomainModel.Entities;
using System.Data;
using Dapper;

namespace Musica.OutputAdapter.Repositories
{
   public static class CancionesRepository
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["musica_app"].ToString();
        static MySqlConnection createConection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static List<Cancion> ConsultarCancion()
        {
            using (var connection = createConection())
            {
                return connection.Query<Cancion>("get_all_canciones", commandType: CommandType.StoredProcedure).AsList();
            }
        }
        public static Cancion ConsultarCancionesId(int id)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", id);
                return connection.Query<Cancion>("get_cancion_id", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
       
    }
}
