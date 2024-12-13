using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_14._0._01
{
    public static class PersonaAccesoDatos
    {
        static string? connectionString;
        static SqlCommand? command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = "Server=.;Database=UTN_DB;Trusted_Connection=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new();

            try
            {
                connection.Open();
                command!.CommandText = "SELECT * FROM Persona";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    personas.Add(new Persona(dataReader["nombre"].ToString()!, dataReader["apellido"].ToString()!));
                }
                return personas;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
