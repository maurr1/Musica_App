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
   public static class DetallesRepository
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["musica_app"].ToString();
        static MySqlConnection createConection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static DetalleSubgenero ConsultarCancionesId(int id)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("_id", id);
                return connection.Query<DetalleSubgenero>("get_detalle_id_cancion", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
