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
        static SqlConnection connection;
        static SqlCommand? command;

        static PersonaAccesoDatos()
        {
            connectionString = "Server=.;Database=UTN_DB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
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
                    personas.Add(new Persona(dataReader["nombre"].ToString()!, dataReader["apellido"].ToString()!, Convert.ToInt32(dataReader["id"])));

                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                command!.Parameters.Clear();
                connection.Open();
                command!.CommandText = $"INSERT INTO Persona (nombre,apellido)   VALUES (@nombre, @apellido)";
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Persona nuevaPersona)
        {
            try
            {
                command!.Parameters.Clear();
                connection.Open();
                command!.CommandText = $"UPDATE Persona SET nombre = @nombre, apellido = @apellido WHERE ID = @ID";
                command.Parameters.AddWithValue("@nombre", nuevaPersona.Nombre);
                command.Parameters.AddWithValue("@apellido", nuevaPersona.Apellido);
                command.Parameters.AddWithValue("@ID", nuevaPersona.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public static void Eliminar(int id)
        {
            try
            {
                command!.Parameters.Clear();
                connection.Open();
                command!.CommandText = $"DELETE FROM Persona WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
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
