using Dapper;
using MusicaAi.DomainModel.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.OutputAdapter.Repositories
{
    public static class GenerosRepository
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["musica_app"].ToString();
        static MySqlConnection createConection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static List<Genero> ConsultarGeneros()
        {
            using (var connection = createConection())
            {
                return connection.Query<Genero>("get_all_generos", commandType: CommandType.StoredProcedure).AsList();
            }
        }
        public static Genero ConsultarGeneroId(int id)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", id);
                return connection.Query<Genero>("get_genero_id", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
