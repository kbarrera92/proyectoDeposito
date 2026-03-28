using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class ProductoStockBajoDTO
    {
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal? EXISTENCIA { get; set; }
        public decimal? STOCKMINIMO { get; set; }
    }
}
