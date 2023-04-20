using System.Data;

namespace DataAccess
{
    public interface IConexion
    {
        DataTable ObtenerDatos(string query);
        
    }
}