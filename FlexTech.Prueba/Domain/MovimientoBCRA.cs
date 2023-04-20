using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MovimientoBCRA
    {
        public int ID {  get; set; }
        public string Operatoria { get; set; }
        public string Transaccion { get; set; }
        public int EntidadDeudora { get; set; }
        public int CuentaDeudora { get; set; }
        public int EntidadAcreedora { get; set; }
        public int CuentaAcreedora { get; set; }
        public decimal Importe { get; set; }
        public string InstruccionDePago { get; set; }
        public DateTime FechaProcesado { get; set; }
        public string NumeroInterno { get; set; }
    }
}
