using DataAccess;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlexTech.Prueba.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BCRAController : ControllerBase
    {
        private readonly IMovimientosBCRADataAccess _movimientosBCRADataAccess;
        public BCRAController(IMovimientosBCRADataAccess movimientosBCRADataAccess) 
        {
            _movimientosBCRADataAccess = movimientosBCRADataAccess;
        }
        [HttpGet]
        [Route("movimientos/{cuentaAcreedora}/credito")]
        public IEnumerable<MovimientoBCRA> GetOrdersByMovimientoBCRA(int cuentaAcreedora) 
        {
            return _movimientosBCRADataAccess.ObtenerListado(cuentaAcreedora);
        }
    }
}
