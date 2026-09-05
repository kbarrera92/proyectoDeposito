using System;
using System.Linq;
using Entidad;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Bs_Pedido
    {
        public static int iddetallepedido { get; set; }
        public static int idpedido { get; set; }
        public static bool crearAbono(ABONOASALDO abono)
        {
            bool status = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.ABONOASALDO.Add(abono);
                    db.SaveChanges();
                    status = true;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return status;
        }

        public static void registrardetalles(AUTOVENTADETA2 ventadeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.AUTOVENTADETA2.Add(ventadeta);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public static void registrardetalles2(AUTOVENTADETA2 ventadeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.AUTOVENTADETA2.Add(ventadeta);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        //Listar pedido
        public static void llenardgv(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from pedido in db.PEDIDO
                          join cliente in db.CLIENTE
                          on pedido.CLIENTE equals cliente.ID
                          select new
                          {
                              Id = pedido.ID,
                              Fecha = pedido.FECHA,
                              Cliente = cliente.NOMBRE,
                              Total = pedido.TOTAL,
                              IdCliente = cliente.ID
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenardgvpedxrep(DataGridView datagrid, DateTime fecha, int repar)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from pedido in db.PEDIDO
                          join cliente in db.CLIENTE
                          on pedido.CLIENTE equals cliente.ID
                          join rep in db.REPARTIDOR
                          on pedido.REPCOBRO equals rep.ID
                          join bit in db.BIT_ABONOSYSALDOS
                          on pedido.ID equals bit.PEDIDO
                          where pedido.FECHA == fecha && rep.ID == repar
                          select new
                          {
                              Id = pedido.ID,
                              Fecha = pedido.FECHA,
                              Cliente = cliente.NOMBRE,
                              Repartidor = rep.NOMBRE == null ? "" : rep.NOMBRE,
                              Total = pedido.TOTAL,
                              Cobrado = bit.COBRADO
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void filtrardgv(DataGridView datagrid, string nombre)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from pedido in db.PEDIDO
                          join cliente in db.CLIENTE
                          on pedido.CLIENTE equals cliente.ID
                          where cliente.NOMBRE.Contains(nombre)
                          select new
                          {
                              Id = pedido.ID,
                              Fecha = pedido.FECHA,
                              Cliente = cliente.NOMBRE,
                              Total = pedido.TOTAL,
                              IdCliente = cliente.ID
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenardgvdetalles(DataGridView datagrid, int pedido)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from det in db.PEDIDODETA
                          join producto in db.PRODUCTO
                          on det.IDPRODUCTO equals producto.ID
                          where det.IDPEDIDO.Equals(pedido)
                          select new
                          {
                              det.ID,
                              det.IDPRODUCTO,
                              producto.DESCRIPCION,
                              det.CANTIDAD,
                              det.PRECIO,
                              det.SUBTOTAL,
                              det.DETALLESAB
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        //Actualizar pedido
        public static void actualizarDetallePedido(int id, int pedido, int cant, decimal precio, decimal subtotal)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from deta in db.PEDIDODETA
                               where deta.ID.Equals(id) && deta.IDPEDIDO.Equals(pedido)
                               select deta;

                foreach (var item in consulta)
                {
                    item.CANTIDAD = cant;
                    item.PRECIO = precio;
                    item.SUBTOTAL = subtotal;
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void borrardetalle(int id, int pedido)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = (from det in db.PEDIDODETA
                                where det.ID.Equals(id) && det.IDPEDIDO.Equals(pedido)
                                select det).ToList();

                foreach (var item in consulta)
                {
                    db.PEDIDODETA.Remove(item);
                }

                db.SaveChanges();
            }
        }

        public static void borrarpedido(int pedido)
        {
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = (from ped in db.PEDIDO
                                    where ped.ID.Equals(pedido)
                                    select ped).ToList();

                    foreach (var item in consulta)
                    {
                        db.PEDIDO.Remove(item);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Se elimino el pedido", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public static bool BorrarDetallePedidoIndividual(int nped, int deta, int produc, decimal cantidad)
        {
            var resp = false;
            int npedido = nped;
            int det = deta;
            int prod = produc;
            var cant = cantidad;
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Utils.ConsultaParametro("CS"));
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("sp_borrarDetallePedido", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("IDDET", det);
            myCmd.Parameters.AddWithValue("IDPED", npedido);

            try
            {
                myCmd.ExecuteNonQuery();
                resp = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar el detalle del pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resp;

        }

        public static bool Validapedidocuadrado(int pedido)
        {
            bool resp = false;
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.PEDIDO.Where(p => p.ID == pedido).Select(p => p.REPCOBRO).FirstOrDefault();

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

        public static bool borrardetallepedido(int pedido)
        {
            bool resp = false;
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = (from ped in db.PEDIDODETA
                                    where ped.IDPEDIDO.Equals(pedido)
                                    select ped).ToList();

                    foreach (var item in consulta)
                    {
                        if (BorrarDetallePedidoIndividual(pedido, item.ID,
                            item.IDPRODUCTO.GetValueOrDefault(), item.CANTIDAD.GetValueOrDefault()))
                        {
                            resp = true;
                        }
                    }
                    //db.SaveChanges();

                }
            }
            catch (Exception e)
            {
                resp = false;

            }
            return resp;
        }

        //Obtener total de PEDIDOS
        public static decimal gettotalhoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.PEDIDO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.TOTAL);
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
                    var consulta = db.PEDIDO
                        .Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin)
                        .Sum(x => x.TOTAL) ?? 0m;
                    total = consulta;
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Obtener total de ABONOS A SALDO
        public static decimal gettotalhoyabonos(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.ABONOASALDO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.IMPORTE);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static decimal gettotalxfechasabonos(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.ABONOASALDO
                        .Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin)
                        .Sum(x => x.IMPORTE) ?? 0m;

                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static long? ObtenerIdPedido(int idAbono)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var abono = db.BIT_ABONOSYSALDOS.FirstOrDefault(a => a.ID == idAbono);
                if (abono == null) return null;

                if (abono.PEDIDO.HasValue)
                {
                    bool existe = db.PEDIDO.Any(p => p.ID == abono.PEDIDO.Value);
                    if (existe) return abono.PEDIDO.Value;
                }

                var pedido = db.PEDIDO.FirstOrDefault(p =>
                    p.CLIENTE == abono.IDCLUENTE &&
                    p.FECHA == abono.FECHA &&
                    p.TOTAL == abono.TOTAL);

                return pedido?.ID;
            }
        }
    }
}
