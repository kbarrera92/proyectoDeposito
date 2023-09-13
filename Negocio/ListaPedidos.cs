using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ListaPedidos
    {
        public DateTime FECHA { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal SUBTOTAL { get; set; }
    }
}
