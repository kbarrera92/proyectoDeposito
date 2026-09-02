using Entidad;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class ReporteMovimientosService
    {
        public List<ReporteMovimientoRow> ObtenerReporte(DateTime desde)
        {
            using (var ctx = new DEPOSITOEntities1())
            {
                return ctx.MOVIMIENTO
                    .Where(m => m.FECHA >= desde)
                    .OrderBy(m => m.ID)
                    .AsEnumerable()
                    .Select(MapearFila)
                    .ToList();
            }
        }

        private ReporteMovimientoRow MapearFila(MOVIMIENTO m)
        {
            var fila = new ReporteMovimientoRow
            {
                FechaHora = m.FECHA,
                Detalle = m.DESCRIPCION,
                Saldo = m.SALDO
            };

            switch ((TipoMovimiento?)m.TIPO)
            {
                case TipoMovimiento.EfectivoDia:
                    fila.Ventas = m.IMPORTE;
                    break;
                case TipoMovimiento.Entrada:
                    fila.Entrada = m.IMPORTE;
                    break;
                case TipoMovimiento.CompraEspecial:
                    fila.Compras = m.IMPORTE;
                    break;
                case TipoMovimiento.Salida:
                    fila.Salidas = m.IMPORTE;
                    break;
            }

            return fila;
        }

    }
}
