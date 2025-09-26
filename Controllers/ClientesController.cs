using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EstadoCuentaApi.Data;
using EstadoCuentaApi.Models;

namespace EstadoCuentaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // 🔎 Buscar cliente por número de documento
        [HttpGet("buscar")]
        public async Task<ActionResult<object>> BuscarCliente([FromQuery] string nroDoc)
        {
            if (string.IsNullOrWhiteSpace(nroDoc))
                return BadRequest(new { message = "Debe proporcionar un número de documento" });

            var cliente = await _context.Clientes
                .Where(c => c.NroDoc == nroDoc)
                .FirstOrDefaultAsync();

            if (cliente == null)
                return NotFound(new { message = "Cliente no encontrado" });

            return Ok(new { idcliente = cliente.IdCliente });
        }
    }
}
