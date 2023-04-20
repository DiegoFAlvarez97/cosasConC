using Domain;

namespace DataAccess
{
    public interface IMovimientosBCRADataAccess
    {
        IList<MovimientoBCRA> ObtenerListado(int cuentaAcreedora);

    }
}