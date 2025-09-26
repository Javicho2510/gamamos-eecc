using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EstadoCuentaApi.Models;
using EstadoCuentaApi.Data;

namespace EstadoCuentaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoCuentaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstadoCuentaController(AppDbContext context)
        {
            _context = context;
        }

        // 🔎 1) Obtener estado de cuenta filtrado opcionalmente por idinmueble
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoCuentaView>>> Get([FromQuery] int? idinmueble)
        {
            var query = _context.Set<EstadoCuentaView>().AsQueryable();

            if (idinmueble.HasValue)
                query = query.Where(x => x.IdInmueble == idinmueble.Value);
                query = query.OrderBy(x => x.Anio).ThenBy(x => x.IdPeriodo);
            var result = await query.ToListAsync();
            return Ok(result);
        }

        // 🔎 2) Nuevo endpoint para traer inmuebles de un cliente
        [HttpGet("inmuebles-por-cliente")]
        public async Task<ActionResult<IEnumerable<object>>> GetInmueblesPorCliente([FromQuery] int idcliente)
        {
            var data = await (from c in _context.ClientesXInmueble
                              join i in _context.Inmuebles on c.IdInmueble equals i.IdInmueble
                              where c.IdCliente == idcliente
                              select new
                              {
                                  idInmueble = i.IdInmueble,
                                  codInmueble = i.CodInmueble
                              }).ToListAsync();

            return Ok(data);
        }
    }
}
