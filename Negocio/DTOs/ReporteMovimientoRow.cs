using System;

namespace Negocio.DTOs
{
    public class ReporteMovimientoRow
    {
        public DateTime? FechaHora { get; set; }
        public string Detalle { get; set; }
        public decimal? Ventas { get; set; }    // TipoMovimiento.EfectivoDia
        public decimal? Entrada { get; set; }   // TipoMovimiento.Entrada
        public decimal? Compras { get; set; }   // TipoMovimiento.CompraEspecial
        public decimal? Salidas { get; set; }   // TipoMovimiento.Salida
        public decimal? Saldo { get; set; }     // se lee directo de MOVIMIENTO.SALDO
    }
}
