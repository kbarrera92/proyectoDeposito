using Entidad;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class MovimientoRegistroService
    {
        public void Registrar(TipoMovimiento tipo, string detalle, decimal importe)
        {
            using (var ctx = new DEPOSITOEntities1()) // <-- mismo DbContext que ya usas
            {
                var movimiento = new MOVIMIENTO
                {
                    FECHA = DateTime.Now,
                    DESCRIPCION = detalle,
                    TIPO = (short)tipo,
                    IMPORTE = importe
                    // SALDO lo calcula el trigger SETEFECTIVO, no se setea aquí
                };

                ctx.MOVIMIENTO.Add(movimiento);
                ctx.SaveChanges();
            }
        }
    }
}
