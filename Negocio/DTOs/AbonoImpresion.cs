using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class AbonoImpresion
    {
        public int ID { get; set; }
        public DateTime? FECHA { get; set; }
        public string NOMBRE { get; set; }
        public decimal? TOTAL { get; set; }
        public decimal? COBRADO { get; set; }
        public decimal? SALDO { get; set; }
        public string REPARTIDOR { get; set; }
    }
}
