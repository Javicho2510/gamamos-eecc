using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 

namespace EstadoCuentaApi.Models
{
    [Table("tb_inmuebles")]
    [Keyless] 
    public class Inmueble
    {
        [Column("idinmueble")]
        public int IdInmueble { get; set; }

        [Column("cod_inmueble")]
        public string CodInmueble { get; set; } = string.Empty;
    }
}
