using System;

namespace Negocio.DTOs
{
    public class CuentaPagarDTO
    {
        public int IdCuenta { get; set; }
        public string Proveedor { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaLimite { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }

        public bool Pagada
        {
            get { return Saldo <= 0; }
        }

        public string Estado
        {
            get { return Pagada ? "Pagada" : "Pendiente"; }
        }

        public int? DiasRestantes
        {
            get
            {
                if (!FechaLimite.HasValue) return null;
                return (FechaLimite.Value.Date - DateTime.Today).Days;
            }
        }
    }
}
