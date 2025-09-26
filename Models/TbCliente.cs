using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstadoCuentaApi.Models
{
    [Table("tb_clientes")]  // 👈 nombre de la tabla
    public class TbCliente
    {
        [Key]
        [Column("idcliente")]
        public int IdCliente { get; set; }

        [Column("nro_doc")]
        public string? NroDoc { get; set; }
    }
}
