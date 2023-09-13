using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Windows.Forms;
using System.Data.Entity;

namespace Negocio
{
    public class Bs_Autoventa
    {
        public static bool actualizartotal(int autoventa, decimal total)
        {
            bool correcto = false;
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = from auto in db.AUTOVENTA
                                   where auto.ID.Equals(autoventa)
                                   select auto;

                    foreach (var item in consulta)
                    {
                        item.TOTAL = total;
                    }

                    db.SaveChanges();
                    correcto = true;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

                return correcto;
        }

        public static void borrardetalle(int id, int pedido)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = (from det in db.AUTOVENTADETA2
                                where det.ID.Equals(id) && det.IDAUTOVENTA.Equals(pedido)
                                select det).ToList();

                foreach (var item in consulta)
                {
                    db.AUTOVENTADETA2.Remove(item);
                }

                db.SaveChanges();
            }
        }

        public static void llenardgv(DataGridView datagrid)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var consulta = from auto in db.AUTOVENTA
                                   join rep in db.REPARTIDOR
                                   on auto.REPARTIDOR equals rep.ID
                                   select new
                                   {
                                       auto.ID,
                                       auto.FECHA,
                                       rep.NOMBRE,
                                       auto.TOTAL
                                   };

                    datagrid.DataSource = consulta.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static void filtrar(DataGridView datagrid, string repa)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var consulta = from auto in db.AUTOVENTA
                                   join rep in db.REPARTIDOR
                                   on auto.REPARTIDOR equals rep.ID
                                   where rep.NOMBRE.Equals(repa)
                                   select new
                                   {
                                       auto.ID,
                                       auto.FECHA,
                                       rep.NOMBRE,
                                       auto.TOTAL
                                   };

                    datagrid.DataSource = consulta.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        public static bool crearautoventa(AUTOVENTA auto)
        {
            bool status = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.AUTOVENTA.Add(auto);
                    db.SaveChanges();
                    status = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return status;
        }

        public static void llenardgvdetalles(DataGridView datagrid, int pedido)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from det in db.AUTOVENTADETA
                          join producto in db.PRODUCTO
                          on det.IDPRODUCTO equals producto.ID
                          where det.IDAUTOVENTA.Equals(pedido)
                          select new
                          {
                              det.ID,
                              det.IDPRODUCTO,
                              producto.DESCRIPCION,
                              det.CANTIDAD,
                              det.PRECIO,
                              det.SUBTOTAL
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenardgvdetalles2(DataGridView datagrid, int pedido)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from det in db.AUTOVENTADETA2
                          join producto in db.PRODUCTO
                          on det.IDPRODUCTO equals producto.ID
                          where det.IDAUTOVENTA.Equals(pedido)
                          select new
                          {
                              det.ID,
                              det.IDPRODUCTO,
                              producto.DESCRIPCION,
                              det.CANTIDAD,
                              det.PRECIO,
                              det.SUBTOTAL
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void actualizarDetalleAutoventa(int id, int pedido, int cant, decimal subtotal)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from deta in db.AUTOVENTADETA
                               where deta.ID.Equals(id) && deta.IDAUTOVENTA.Equals(pedido)
                               select deta;

                foreach (var item in consulta)
                {                    
                    item.CANTIDAD = cant;
                    item.SUBTOTAL = subtotal;
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Obtener total de autoventa
        public static decimal gettotalhoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.AUTOVENTA.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal gettotalxfechas(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.AUTOVENTA.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }
    }
}
