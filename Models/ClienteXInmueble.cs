using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 

namespace EstadoCuentaApi.Models
{
    [Table("tb_clientesxinmueble")]
    [Keyless]
    public class ClienteXInmueble
    {
        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("idinmueble")]
        public int IdInmueble { get; set; }
    }
}
