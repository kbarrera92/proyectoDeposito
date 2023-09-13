using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Bs_Utilidad
    {
        public static void listartodo(DataGridView datagrid, DateTime ini, DateTime fin)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var consulta2 = db.PRODUCTO.GroupJoin(db.PEDIDODETA, pro => pro.ID, ped => ped.IDPRODUCTO, (pro, ped) => new
                {
                    pro, ped

                })
                .GroupJoin(db.PEDIDO, x => x.ped.FirstOrDefault().IDPEDIDO, y => y.ID, (x, y) => new { x, y })
                .Select(m => new ListaVendidos
                {
                    codigo = m.x.pro.ID,
                    descripcion = m.x.pro.DESCRIPCION,
                    cantidad = m.x.ped.Sum(a => a.CANTIDAD) == null ? 0 : m.x.ped.Sum(a => a.CANTIDAD),
                    precio = m.x.pro.PRECIO * m.x.ped.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.x.pro.PRECIO * (decimal)m.x.ped.Sum(a => a.CANTIDAD),
                    costo = m.x.pro.COSTO * m.x.ped.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.x.pro.COSTO * (decimal)m.x.ped.Sum(a => a.CANTIDAD),
                    utilidad = ((decimal)m.x.pro.PRECIO * (decimal)m.x.ped.Sum(a => a.CANTIDAD)) - ((decimal)m.x.pro.COSTO * (decimal)m.x.ped.Sum(a => a.CANTIDAD)),
                    fecha = m.y.FirstOrDefault().FECHA
                });


                foreach (var item in consulta2)
                {
                    
                    if(item.fecha >= ini && item.fecha <= fin)
                    {
                        datagrid.Rows.Add(

                        item.codigo,
                        item.descripcion,
                        string.Format("{0:N2}", item.cantidad),
                        string.Format("{0:N2}", item.precio),
                        string.Format("{0:N2}", item.costo),
                        string.Format("{0:N2}", item.precio - item.costo)

                        );
                    }
                    
                }

                //datagrid.DataSource = consulta1.ToList();

            }
            
        }

        public static void listartodo1(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var consulta1 = db.PRODUCTO.GroupJoin(db.VENTADETA, pro => pro.ID, ven => ven.IDPRODUCTO, (pro, ven) => new
                {
                    pro,
                    ven

                }).Select(m => new ListaVendidos
                {
                    codigo = m.pro.ID,
                    descripcion = m.pro.DESCRIPCION,
                    cantidad = m.ven.Sum(a => a.CANTIDAD).Equals(null) ? 0 : m.ven.Sum(a => a.CANTIDAD),
                    precio = m.pro.PRECIO * m.ven.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.pro.PRECIO * m.ven.Sum(a => a.CANTIDAD),
                    costo = m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD),
                    utilidad = ((decimal)m.pro.PRECIO * (decimal)m.ven.Sum(a => a.CANTIDAD)) - ((decimal)m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD))
                });


                foreach (var item in consulta1)
                {
                    datagrid.Rows.Add(

                        item.codigo,
                        item.descripcion,
                        string.Format("{0:N2}", item.cantidad),
                        string.Format("{0:N2}", item.precio),
                        string.Format("{0:N2}", item.costo),
                        string.Format("{0:N2}", item.precio - item.costo)

                        );
                }

                //datagrid.DataSource = consulta1.ToList();

            }

        }

        public static void listartodo2(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var consulta1 = db.PRODUCTO.GroupJoin(db.AUTOVENTADETA2, pro => pro.ID, ven => ven.IDPRODUCTO, (pro, ven) => new
                {
                    pro,
                    ven

                }).Select(m => new ListaVendidos
                {
                    codigo = m.pro.ID,
                    descripcion = m.pro.DESCRIPCION,
                    cantidad = m.ven.Sum(a => a.CANTIDAD).Equals(null) ? 0 : m.ven.Sum(a => a.CANTIDAD),
                    precio = m.pro.PRECIO * m.ven.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.pro.PRECIO * m.ven.Sum(a => a.CANTIDAD),
                    costo = m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD) == null ? 0.00m : (decimal)m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD),
                    utilidad = ((decimal)m.pro.PRECIO * (decimal)m.ven.Sum(a => a.CANTIDAD)) - ((decimal)m.pro.COSTO * m.ven.Sum(a => a.CANTIDAD))
                });


                foreach (var item in consulta1)
                {
                    datagrid.Rows.Add(

                        item.codigo,
                        item.descripcion,
                        string.Format("{0:N2}", item.cantidad),
                        string.Format("{0:N2}", item.precio),
                        string.Format("{0:N2}", item.costo),
                        string.Format("{0:N2}", item.precio - item.costo)

                        );
                }

                //datagrid.DataSource = consulta1.ToList();

            }

        }


    }
}
