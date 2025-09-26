using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EstadoCuentaApi.Models
{
    [Keyless]
    [Table("tb_clientesxinmueble")] // 👈 nombre de la tabla
    public class ClienteInmuebleView
    {
        [Column("idinmueble")]
        public int IdInmueble { get; set; }

        [Column("cod_inmueble")]
        public string CodInmueble { get; set; } = string.Empty;
    }
}
