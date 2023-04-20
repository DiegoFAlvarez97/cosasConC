using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MovimientosBCRADataAccess : IMovimientosBCRADataAccess
    {
        private readonly IConexion _conexion;
        public MovimientosBCRADataAccess(IConexion conexion)
        {
            _conexion = conexion;
        }
        public IList<MovimientoBCRA> ObtenerListado(int cuentaAcreedora)
        {
            var list = new List<MovimientoBCRA>();
            var dt = _conexion.ObtenerDatos("SELECT * FROM movimientosBcra WHERE CuentaAcreedora = " + cuentaAcreedora.ToString());
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new MovimientoBCRA
                {
                    ID = Convert.ToInt32(item["id"]),
                    Operatoria = item["Operatoria"].ToString(),
                    Transaccion = item["Transaccion"].ToString(),
                    EntidadDeudora = Convert.ToInt32(item["EntidadDeudora"]),
                    CuentaAcreedora = Convert.ToInt32(item["CuentaAcreedora"]),
                    EntidadAcreedora = Convert.ToInt32(item["EntidadAcreedora"]),
                    CuentaDeudora = Convert.ToInt32(item["CuentaDeudora"]),
                    Importe = Convert.ToDecimal(item["Importe"]),
                    InstruccionDePago = item["InstruccionDePago"].ToString(),
                    FechaProcesado = Convert.ToDateTime(item["FechaProcesado"]),
                    NumeroInterno = item["NumeroInterno"].ToString()

                });
            }
            return list;
        }
    }
}
