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
        }
    }
}
