using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Conexion : IConexion
    {
        private readonly SqlConnection _sqlConnection;
        public Conexion(string conexionString)
        {
            _sqlConnection = new SqlConnection(conexionString);
        }

        
        public DataTable ObtenerDatos(string query)
        {
            var dt = new DataTable();
            _sqlConnection.Open();
            var da = new SqlDataAdapter(query, _sqlConnection);
            da.Fill(dt);
            _sqlConnection.Close();
            return dt;
        }
    }
}
