using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;  // 👈 AGREGA ESTA LÍNEA

namespace EstadoCuentaApi.Models
{
    [Keyless]              // 👈 ahora ya no dará error
    [Table("v_eecc")]
    public class EstadoCuentaView
    {
        [Column("idinmueble")]
        public int IdInmueble { get; set; }

        public int Anio { get; set; }

        [Column("desc_periodo")]
        public string? DescPeriodo { get; set; }

        [Column("cod_inmueble")]
        public string? CodInmueble { get; set; }

        [Column("nro_serie")]
        public string? NroSerie { get; set; }

        [Column("nro_comprob")]
        public int? NroComprob { get; set; }

        [Column("fecha_emision")]
        public DateTime? FechaEmision { get; set; }

        [Column("importe_fac")]
        public decimal? ImporteFac { get; set; }

        [Column("fecha_cob")]
        public DateTime? FechaCob { get; set; }

        [Column("tipo_pago")]
        public string? TipoPago { get; set; }

        [Column("importe_cob")]
        public decimal? ImporteCob { get; set; }

	[Column("idperiodo")]
        public int? IdPeriodo { get; set; }

    }
}
