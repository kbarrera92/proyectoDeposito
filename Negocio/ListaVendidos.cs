using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ListaVendidos
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public decimal? cantidad { get; set; }
        public decimal? precio { get; set; }
        public decimal? costo { get; set; }
        public decimal? utilidad { get; set; }
        public DateTime? fecha { get; set; }
    }
}
