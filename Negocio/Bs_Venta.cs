using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using System.Data.Entity;

namespace Negocio
{
    public class Bs_Venta
    {

        //Obtener el total de la ventas al crédito
        public static decimal gettotalventascredito()
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.VENTASCREDITO.Where(x => x.COBRADA == null).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal gettotalventascreditopagadas(DateTime fecha)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.VENTASCREDITO.Where(x => x.COBRADA != null && x.FECHACOBRO == fecha).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }


        public static decimal gettotalventascreditopagadasxfecha(DateTime fechai, DateTime fechaf)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.VENTASCREDITO.Where(x => x.COBRADA != null && x.FECHACOBRO >= fechai && x.FECHACOBRO <= fechaf).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static void verventascredito(DataGridView dgv)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTASCREDITO.Select(x => new
                {
                    x.ID,
                    x.FECHA,
                    x.CONCEPTO,
                    x.TOTAL,
                    x.COBRADA,
                    x.FECHACOBRO
                }).OrderBy(x => x.COBRADA);

                var lista = consulta.ToList();
                foreach (var item in lista)
                {
                    dgv.Rows.Add(item.ID.ToString(),
                        item?.FECHA.GetValueOrDefault().ToString(),
                        item.CONCEPTO.ToString(),
                        item?.TOTAL.GetValueOrDefault().ToString(),
                        item?.COBRADA == true ? "Cobrada" : "Sin cobrar",
                        item?.FECHACOBRO?.ToString() ?? "");
                }
            }
        }

        public static void llenardgv(DataGridView dgv)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTA.Join(db.USUARIO, sale => sale.USUARIO, user => user.ID, (sale, user) => new { sale, user })                    
                    .Select(n => new
                    {
                        n.sale.ID,
                        n.sale.FECHA,
                        n.sale.HORA,
                        n.user.NOMBRE,
                        n.sale.CONCEPTO,
                        n.sale.TOTAL
                    });

                dgv.DataSource = consulta.ToList();
            }
        }

        public static void llenardgvdetalles(DataGridView dgv, long nventa)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTADETA.Join(db.PRODUCTO, det => det.IDPRODUCTO, ven => ven.ID, (det, ven) => new { det, ven })
                    .Where(x => x.det.VENTA == nventa)
                    .Select(n => new
                    {
                        n.det.ID,
                        n.det.IDPRODUCTO,
                        n.ven.DESCRIPCION,
                        n.det.CANTIDAD,
                        n.det.PRECIO,
                        n.det.SUBTOTAL,
                        OBSERVACIONES = n.det.DESCRIPCION
                    });

                dgv.DataSource = consulta.ToList();
            }
        }

        public static bool borrarventa(int id)
        {
            bool res = false;

            try
            {
                using (Entidad.DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = from ven in db.VENTA
                                   where ven.ID == id
                                   select ven;

                    foreach (var item in consulta)
                    {
                        db.VENTA.Remove(item);
                    }

                    db.SaveChanges();
                    res = true;
                }
            }
            catch (Exception)
            {

                res = false;
            }
            

            return res;
        }

        public static void llenardgvporusuario(DataGridView dgv, string us)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTA.Join(db.USUARIO, sale => sale.USUARIO, user => user.ID, (sale, user) => new {sale, user})
                    .Where(m => m.user.NOMBRE.Contains(us))
                    .Select(n => new
                    {
                        n.sale.ID,
                        n.sale.FECHA,
                        n.sale.HORA,
                        n.user.NOMBRE,
                        n.sale.CONCEPTO,
                        n.sale.TOTAL
                    });

                dgv.DataSource = consulta.ToList();
            }
        }

        public static bool cobrarventacredito(int venta)
        {
            bool exito = false;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = from efec in db.VENTASCREDITO
                                   where efec.ID.Equals(venta)
                                   select efec;

                    foreach (var item in consulta)
                    {
                        item.COBRADA = true;
                        item.FECHACOBRO = DateTime.Now.Date;
                    }
                    db.SaveChanges();
                    exito = true;
                }
            }
            catch (Exception)
            {

                exito = false;
            }


            return exito;
        }

        public static void llenardgvporconcepto(DataGridView dgv, string con)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTA.Join(db.USUARIO, sale => sale.USUARIO, user => user.ID, (sale, user) => new { sale, user })
                    .Where(m => m.sale.CONCEPTO.Contains(con))
                    .Select(n => new
                    {
                        n.sale.ID,
                        n.sale.FECHA,
                        n.sale.HORA,
                        n.user.NOMBRE,
                        n.sale.CONCEPTO,
                        n.sale.TOTAL
                    });

                dgv.DataSource = consulta.ToList();
            }
        }

        public static void llenardgvporfechas(DataGridView dgv, DateTime ini, DateTime fin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.VENTA.Join(db.USUARIO, sale => sale.USUARIO, user => user.ID, (sale, user) => new { sale, user })
                    .Where(m => DbFunctions.TruncateTime(m.sale.FECHA) >= ini.Date && DbFunctions.TruncateTime(m.sale.FECHA) <= fin.Date)
                    .Select(n => new
                    {
                        n.sale.ID,
                        n.sale.FECHA,
                        n.sale.HORA,
                        n.user.NOMBRE,
                        n.sale.CONCEPTO,
                        n.sale.TOTAL
                    });

                dgv.DataSource = consulta.ToList();
            }
        }

        public static void llenardgvporfechascorte(DataGridView dgv, DateTime ini, DateTime fin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {                
                var consulta1 = db.VENTADETA.Join(db.VENTA, vd => vd.VENTA, v => v.ID, (vd, v) => new { vd, v })
                    .Join(db.PRODUCTO, p => p.vd.IDPRODUCTO, pro => pro.ID, (p, pro) => new { p, pro })
                    .Where(m => DbFunctions.TruncateTime(m.p.v.FECHA) >= ini.Date && DbFunctions.TruncateTime(m.p.v.FECHA) <= fin.Date)
                    .Select(n => new
                    {
                        n.p.vd.ID,
                        n.pro.DESCRIPCION,
                        n.p.vd.CANTIDAD,
                        n.p.vd.PRECIO,
                        n.p.vd.SUBTOTAL
                    });

                dgv.DataSource = consulta1.ToList();
            }
        }

        public static bool registrarventa(VENTA venta)
        {
            bool estado = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.VENTA.Add(venta);
                    db.SaveChanges();
                    estado = true;
                }
                catch (Exception)
                {
                    

                }

            }
            return estado;

        }

        public static bool registrarsaldoenvase(HISTORIALENVASE histo)
        {
            bool estado = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.HISTORIALENVASE.Add(histo);
                    db.SaveChanges();
                    estado = true;
                }
                catch (Exception)
                {


                }

            }
            return estado;

        }

        public static bool registrarventacredito(VENTASCREDITO venta)
        {
            bool estado = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.VENTASCREDITO.Add(venta);
                    db.SaveChanges();
                    estado = true;
                }
                catch (Exception)
                {


                }

            }
            return estado;

        }

        public static void registrarbitacoraventa(BITACORAVENTASTRAB bit)
        {
            
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.BITACORAVENTASTRAB.Add(bit);
                    db.SaveChanges();
                    
                }
                catch (Exception)
                {


                }

            }
            

        }

        public static bool ValidaVentaCuadrada(int venta)
        {
            bool resp = false;
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.VENTA.Where(p => p.ID == venta).Select(p => p.COBRADO).FirstOrDefault();

                    if (!(consulta is null))
                        resp = true;
                }
            }
            catch
            {
                throw;
            }

            return resp;
        }

        public static bool borrardetallesventas(int venta)
        {
            bool resp = false;

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from ven in db.VENTADETA
                               where ven.VENTA == venta
                               select ven;

                foreach (var item in consulta)
                {
                    db.VENTADETA.Remove(item);
                }

                db.SaveChanges();
                resp = true;
            }

            return resp;
        }

        public static bool registrarpedido(PEDIDO venta)
        {
            bool estado = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.PEDIDO.Add(venta);
                    db.SaveChanges();
                    estado = true;
                }
                catch (Exception)
                {


                }

            }
            return estado;

        }

        public static void registrardetalles(VENTADETA ventadeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.VENTADETA.Add(ventadeta);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static void eliminarVenta(int id, int cob, decimal tot)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var x = (from venta in db.VENTA
                            where venta.ID == id
                            select venta);

                    foreach (var item in x.ToList())
                    {
                        item.TOTAL = tot;
                        item.COBRADO = cob;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool devolverenvase(int id)
        {
            bool success = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var x = (from histo in db.HISTORIALENVASE
                             where histo.ID == id
                             select histo);

                    foreach (var item in x.ToList())
                    {
                        item.FECHADEVUELTO = DateTime.Today.Date;
                        
                    }
                    db.SaveChanges();
                    success = true;
                }
                catch (Exception)
                {

                    success = false;
                }
            }
            return success;
        }

        public static void cobrarVenta(int id, int cob)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var x = (from venta in db.VENTA
                             where venta.ID == id
                             select venta);

                    foreach (var item in x.ToList())
                    {
                        
                        item.COBRADO = cob;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void eliminarpedido(int id, int cob)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    var x = (from venta in db.PEDIDO
                             where venta.ID == id
                             select venta);

                    foreach (var item in x.ToList())
                    {                        
                        item.REPCOBRO = cob;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void registrardetallespedido(PEDIDODETA ventadeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.PEDIDODETA.Add(ventadeta);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static decimal gettotalhoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.VENTA.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.TOTAL);
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
                    var consulta = db.VENTA
                        .Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin)
                        .Sum(x => x.TOTAL) ?? 0m;
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
