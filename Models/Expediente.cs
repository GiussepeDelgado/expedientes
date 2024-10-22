using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionExpedientesAPI.Models
{
    [Table("expediente")]
    public class Expediente
    {
        [Key]
        [Column("indice")]
        public int Indice { get; set; }

        [Column("expediente")]
        public int? NumeroExpediente { get; set; }

        [Column("fecha_recep")]
        public DateTime? FechaRecepcion { get; set; }

        [Column("anio", TypeName = "char(4)")]
        public string? Anio { get; set; }  // Permitir null

        [Column("hora")]
        public TimeSpan? Hora { get; set; }

        [Column("razon_social")]
        public string? RazonSocial { get; set; }  // Permitir null

        [Column("asunto")]
        public string? Asunto { get; set; }  // Permitir null

        [Column("remitente")]
        public string? Remitente { get; set; }  // Permitir null

        [Column("cod_dep")]
        public string? CodigoDependencia { get; set; }  // Permitir null

        [Column("accion")]
        public string? Accion { get; set; }  // Permitir null

        [Column("folio")]
        public int? Folio { get; set; }

        [Column("estado")]
        public string Estado { get; set; }  // Campo no nulo por defecto

        [Column("ubicacion")]
        public string? Ubicacion { get; set; }  // Permitir null

        [Column("destino")]
        public string? Destino { get; set; }  // Permitir null

        [Column("observacion")]
        public string? Observacion { get; set; }  // Permitir null

        [Column("usuario")]
        public string? Usuario { get; set; }  // Permitir null

        [Column("adjunto")]
        public string? Adjunto { get; set; }  // Permitir null

        [Column("reservado")]
        public bool? Reservado { get; set; }

        [Column("clave")]
        public int? Clave { get; set; }

        [Column("referencia")]
        public string? Referencia { get; set; }  // Permitir null

        [Column("tipo_exp")]
        public int? TipoExpediente { get; set; }

        [Column("cod_sede")]
        public int? CodigoSede { get; set; }

        [Column("ult_area")]
        public string? UltimaArea { get; set; }  // Permitir null

        [Column("ult_fecha")]
        public DateTime? UltimaFecha { get; set; }

        [Column("ult_hora")]
        public TimeSpan? UltimaHora { get; set; }

        [Column("ult_nro_prov")]
        public string? UltimoNumeroProv { get; set; }  // Permitir null
    }
}
