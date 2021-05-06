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
    public static class PersonasRepository
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["musica_app"].ToString();

        static MySqlConnection createConection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static List<Persona> ConsultarPersonas()
        {
            using (var connection = createConection())
            {
                return connection.Query<Persona>("get_all_personas", commandType: CommandType.StoredProcedure).AsList();
            }
        }


        public static Persona ConsultarPersonaId(int id)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", id);
                return connection.Query<Persona>("get_persona_id", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public static Persona InsertarPersona(string nombre, string contraseña, string administrador, bool contribuidor)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();

                parameters.Add("p_id", DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("p_nombre", nombre);
                parameters.Add("p_contraseña", contraseña);
                parameters.Add("p_administrador", administrador);
                parameters.Add("p_contribuidor", contribuidor);
                connection.Execute("insertar_persona", parameters, commandType: CommandType.StoredProcedure);

                var id = parameters.Get<int>("p_id");

                return new Persona(id, nombre, contraseña, administrador, contribuidor);
            }
        }
       
        public static void EliminarPersona(int matricula)
        {
            using (var connection = createConection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id", matricula);
                connection.Execute("eliminar_persona", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
