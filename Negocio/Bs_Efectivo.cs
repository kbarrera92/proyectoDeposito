using Entidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Negocio
{
    public class Bs_Efectivo
    {
        //Obtener efectivo
        public static decimal getefectivohoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => DbFunctions.TruncateTime(x.auto.FECHA) == hoy && x.deta.CLIENTE == null)
                        .Select(x => x.deta.SUBTOTAL).DefaultIfEmpty().Sum();

                    var consulta2 = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => DbFunctions.TruncateTime(x.auto.FECHA) == hoy && x.deta.CLIENTE != null)
                        .Select(x => x.deta.ABONO).DefaultIfEmpty().Sum();

                    var consulta3 = db.ABONOASALDO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.IMPORTE);

                    var consulta1 = db.VENTA.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.TOTAL);

                    total = Convert.ToDecimal(consulta) + Convert.ToDecimal(consulta2) + Convert.ToDecimal(consulta3) + Convert.ToDecimal(consulta1);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal getefectivofechas(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => (DbFunctions.TruncateTime(x.auto.FECHA) >= ini && DbFunctions.TruncateTime(x.auto.FECHA) <= fin) && x.deta.CLIENTE == null)
                        .Select(x => x.deta.SUBTOTAL).DefaultIfEmpty().Sum();

                    var consulta2 = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => (DbFunctions.TruncateTime(x.auto.FECHA) >= ini && DbFunctions.TruncateTime(x.auto.FECHA) <= fin) && x.deta.CLIENTE != null)
                        .Select(x => x.deta.ABONO).DefaultIfEmpty().Sum();

                    var consulta3 = db.ABONOASALDO.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Sum(x => x.IMPORTE);

                    var consulta1 = db.VENTA.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Sum(x => x.TOTAL);

                    total = Convert.ToDecimal(consulta) + Convert.ToDecimal(consulta2) + Convert.ToDecimal(consulta3) + Convert.ToDecimal(consulta1);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }
        //FINAL DE EFECTIVO

        //INICIO CREDITO
        public static decimal getcreditohoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta2 = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => DbFunctions.TruncateTime(x.auto.FECHA) == hoy && x.deta.CLIENTE != null)
                        .Select(x => x.deta.SUBTOTAL - x.deta.ABONO).DefaultIfEmpty().Sum();

                    var consulta = db.PEDIDO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.TOTAL);

                    total = Convert.ToDecimal(consulta) + Convert.ToDecimal(consulta2);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal getcreditofechas(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta2 = db.AUTOVENTA
                        .Join(db.AUTOVENTADETA2, auto => auto.ID, deta => deta.IDAUTOVENTA, (auto, deta) => new
                        { auto, deta })
                        .Where(x => (DbFunctions.TruncateTime(x.auto.FECHA) >= ini && DbFunctions.TruncateTime(x.auto.FECHA) <= fin) && x.deta.CLIENTE != null)
                        .Select(x => x.deta.SUBTOTAL - x.deta.ABONO).DefaultIfEmpty().Sum();

                    var consulta = db.PEDIDO.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Sum(x => x.TOTAL);

                    total = Convert.ToDecimal(consulta2) + Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }
        //FIN CREDITO

        //INICIO SALIDAS
        public static decimal getsalidashoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta2 = db.COMPRA.Where(x => DbFunctions.TruncateTime(x.FECHACOMPRA) == hoy && x.FORMAPAGO == 1 && (x.TIPO == 0 || x.TIPO == null)).Sum(x => x.TOTAL);

                    var consulta = db.CXPABONO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.IMPORTE);

                    var consulta1 = db.SALIDAEFECTIVO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Select(x => x.IMPORTE).DefaultIfEmpty().Sum();

                    total = Convert.ToDecimal(consulta) + Convert.ToDecimal(consulta2) + Convert.ToDecimal(consulta1);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal getventascreditofecha(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {

                    var consulta = db.VENTASCREDITO.Where(x => x.FECHA == hoy).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal getsalidasfechas(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta2 = db.COMPRA.Where(x => (DbFunctions.TruncateTime(x.FECHACOMPRA) >= ini && DbFunctions.TruncateTime(x.FECHACOMPRA) <= fin) && x.FORMAPAGO == 1 && (x.TIPO == 0 || x.TIPO == null)).Sum(x => x.TOTAL);

                    var consulta = db.CXPABONO.Where(x => (DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin)).Sum(x => x.IMPORTE);

                    var consulta1 = db.SALIDAEFECTIVO.Where(x => (DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin)).Select(x => x.IMPORTE).DefaultIfEmpty().Sum();

                    total = Convert.ToDecimal(consulta) + Convert.ToDecimal(consulta2) + Convert.ToDecimal(consulta1);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }
        //

        //Hoy
        public static decimal gettotalhoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.SALIDAEFECTIVO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Select(x => x.IMPORTE).DefaultIfEmpty().Sum();
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Por fechas
        public static decimal gettotalhoyporfechas(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.SALIDAEFECTIVO.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Select(x => x.IMPORTE).DefaultIfEmpty().Sum();
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static void llenargastosvarios(DataGridView datagrid)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from gastos in db.SALIDAEFECTIVO
                               select gastos;

                datagrid.DataSource = consulta.ToList();
            }
        }

        public static void llenargastosvariosfecha(DataGridView datagrid, DateTime fechaini, DateTime fechafin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consul = db.SALIDAEFECTIVO
                    .Where(x => DbFunctions.TruncateTime(x.FECHA) >= fechaini && DbFunctions.TruncateTime(x.FECHA) <= fechafin)
                    .Select(x => x);

                datagrid.DataSource = consul.ToList();
            }
        }

        public static bool crearNuevo(SALIDAEFECTIVO salida)
        {
            bool resp = false;

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.SALIDAEFECTIVO.Add(salida);
                    db.SaveChanges();
                    resp = true;
                }
                catch (Exception)
                {

                }
            }

            return resp;
        }

        public static bool crearNuevoMov(MOVIMIENTO mov, DEPOSITOEntities1 context)
        {
            bool resp = false;

            try
            {
                context.MOVIMIENTO.Add(mov);
                context.SaveChanges();

                resp = true;
            }
            catch (Exception)
            {
                throw;
            }

            return resp;
        }

        public static void llenardgvmovimientos(DataGridView datagrid)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from mov in db.MOVIMIENTO
                               join trans in db.TRANSACCION
                               on mov.TIPO equals trans.ID
                               select new
                               {
                                   mov.ID,
                                   mov.FECHA,
                                   mov.DESCRIPCION,
                                   trans.NOMBRETRANS,
                                   mov.IMPORTE
                               };

                datagrid.DataSource = consulta.ToList();


            }

        }

        public static void borrarmov(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from mov in db.MOVIMIENTO
                               where mov.ID == id
                               select mov;

                foreach (var item in consulta)
                {
                    db.MOVIMIENTO.Remove(item);
                }

                db.SaveChanges();
            }

        }

        public static void llenardgvmovimientosxfecha(DataGridView datagrid, DateTime ini, DateTime fin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from mov in db.MOVIMIENTO
                               join trans in db.TRANSACCION
                               on mov.TIPO equals trans.ID
                               where mov.FECHA >= ini && mov.FECHA <= fin
                               select new
                               {
                                   mov.FECHA,
                                   mov.DESCRIPCION,
                                   trans.NOMBRETRANS,
                                   mov.IMPORTE
                               };

                datagrid.DataSource = consulta.ToList();


            }

        }

        public static decimal getCapital(short suc)
        {
            decimal capital = 0;

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = db.SUCURSAL.Where(x => x.ID == suc).Select(x => x.CAPITAL).DefaultIfEmpty().Sum();

                capital = Convert.ToDecimal(consulta);
            }

            return capital;

        }

        public static bool cambiarcapital(short suc, decimal nuevo)
        {
            bool exito = false;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = from efec in db.SUCURSAL
                                   where efec.ID.Equals(suc)
                                   select efec;

                    foreach (var item in consulta)
                    {
                        item.CAPITAL = nuevo;
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


    }
}
