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
    public class Bs_Compra
    {
        public static int ncompra { get; set; }
        public static decimal gettotalhoy(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.COMPRA.Where(x => DbFunctions.TruncateTime(x.FECHACOMPRA) == hoy && x.FORMAPAGO == 1 && (x.TIPO == 0 || x.TIPO == null)).Sum(x => x.TOTAL);



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
                    var consulta = db.COMPRA.Where(x => DbFunctions.TruncateTime(x.FECHACOMPRA) >= ini && DbFunctions.TruncateTime(x.FECHACOMPRA) <= fin && x.FORMAPAGO == 1 && (x.TIPO == 0 || x.TIPO == null)).Sum(x => x.TOTAL);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Obtner el total de las cxp
        public static decimal gettotalcxp()
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.CUENTAXPAGAR.Sum(x => x.SALDO);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Obtener total de cuentas por pagar
        //Hoy

        public static decimal gettotalhoycxp(DateTime hoy)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.CXPABONO.Where(x => DbFunctions.TruncateTime(x.FECHA) == hoy).Sum(x => x.IMPORTE);
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
        public static decimal gettotalhoyporfechascxp(DateTime ini, DateTime fin)
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.CXPABONO.Where(x => DbFunctions.TruncateTime(x.FECHA) >= ini && DbFunctions.TruncateTime(x.FECHA) <= fin).Sum(x => x.IMPORTE);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }


        public static void llenarcmb(ComboBox combo)
        {
            using (DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.FORMAPAGO
                           select new
                           {
                               Codigo = a.ID,
                               Descripcion = a.DESCRIPCION

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Descripcion";

            }
        }

        public static void llenardgvcompras(DataGridView datagrid)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from compras in db.COMPRA
                          join prov in db.PROVEEDOR
                          on compras.PROVEEDOR equals prov.ID
                          join fp in db.FORMAPAGO
                          on compras.FORMAPAGO equals fp.ID
                          select new
                          {
                              compras.ID,
                              compras.FECHACOMPRA,
                              compras.HORA,
                              compras.FECHAPAGO,
                              compras.PROVEEDOR,
                              prov.NOMBRE,
                              compras.USUARIO,
                              compras.DOCUMENTO,
                              compras.TOTAL
                          };

                datagrid.DataSource = lst.ToList();
            }

        }

        public static void llenardgvcompras1(DataGridView datagrid, string prove)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from compras in db.COMPRA
                          join prov in db.PROVEEDOR
                          on compras.PROVEEDOR equals prov.ID
                          join fp in db.FORMAPAGO
                          on compras.FORMAPAGO equals fp.ID
                          where prov.NOMBRE.Contains(prove)
                          select new
                          {
                              compras.ID,
                              compras.FECHACOMPRA,
                              compras.HORA,
                              compras.FECHAPAGO,
                              compras.PROVEEDOR,
                              prov.NOMBRE,
                              compras.USUARIO,
                              compras.DOCUMENTO,
                              compras.TOTAL
                          };

                datagrid.DataSource = lst.ToList();
            }

        }

        public static void llenardgvcompras2(DataGridView datagrid, string docu)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from compras in db.COMPRA
                          join prov in db.PROVEEDOR
                          on compras.PROVEEDOR equals prov.ID
                          join fp in db.FORMAPAGO
                          on compras.FORMAPAGO equals fp.ID
                          where compras.DOCUMENTO.Contains(docu)
                          select new
                          {
                              compras.ID,
                              compras.FECHACOMPRA,
                              compras.HORA,
                              compras.FECHAPAGO,
                              compras.PROVEEDOR,
                              prov.NOMBRE,
                              compras.USUARIO,
                              compras.DOCUMENTO,
                              compras.TOTAL
                          };

                datagrid.DataSource = lst.ToList();
            }

        }

        public static void llenardgvcompras3(DataGridView datagrid, DateTime fechaini, DateTime fechafin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from compras in db.COMPRA
                          join prov in db.PROVEEDOR
                          on compras.PROVEEDOR equals prov.ID
                          join fp in db.FORMAPAGO
                          on compras.FORMAPAGO equals fp.ID
                          where compras.FECHACOMPRA >= fechaini.Date && compras.FECHACOMPRA <= fechafin.Date
                          select new
                          {
                              compras.ID,
                              compras.FECHACOMPRA,
                              compras.HORA,
                              compras.FECHAPAGO,
                              compras.PROVEEDOR,
                              prov.NOMBRE,
                              compras.USUARIO,
                              compras.DOCUMENTO,
                              compras.TOTAL
                          };

                datagrid.DataSource = lst.ToList();
            }

        }

        public static double calculartotal(DataGridView datagrid, short columna)
        {
            double total = 0;

            foreach  (DataGridViewRow row in datagrid.Rows)
            {
                total += double.Parse(row.Cells[columna].Value.ToString());
            }

            return total;
        }

        public static void llenardgvcomprasdet(DataGridView datagrid, long compra)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from compras in db.COMPRADETA
                          join producto in db.PRODUCTO
                          on compras.IDPRODUCTO equals producto.ID
                          where compras.IDCOMPRA == compra
                          select new
                          {
                              compras.ID,
                              compras.IDPRODUCTO,
                              producto.DESCRIPCION,
                              compras.PRECIO,
                              compras.CANTIDAD,
                              compras.SUBTOTAL
                          };

                datagrid.DataSource = lst.ToList();
            }

        }


        public static string getdatosproveedor(string nit)
        {
            string nombreprov = "";
            using (DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var consulta = db.PROVEEDOR.Where(x => x.NIT.Equals(nit)).Select(x => x.NOMBRE);

                if (consulta.Count() > 0)
                {
                    foreach (var item in consulta)
                    {
                        nombreprov = item;
                    }
                }
                
                return nombreprov;
            }
        }

        public static int getdatosproveedor1(string nit)
        {
            int nombreprov = 0;
            using (DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var consulta = db.PROVEEDOR.Where(x => x.NIT.Equals(nit)).Select(x => x.ID);

                if (consulta.Count() > 0)
                {
                    foreach (var item in consulta)
                    {
                        nombreprov = item;
                    }
                }

                return nombreprov;
            }
        }

        public static void filtrardgv(DataGridView datagrid, string desc)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from prod in db.PRODUCTO
                          where prod.ESTADO == true && prod.DESCRIPCION.Contains(desc)
                          select new
                          {
                              Codigo = prod.ID,
                              Descripcion = prod.DESCRIPCION,
                              Costo = prod.COSTO,
                              Precio = prod.PRECIO,
                              Presentacion = prod.PRESENTACION,
                              Marca = prod.MARCA,
                              Existencia = prod.EXISTENCIA
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static bool registrarcompra(COMPRA compra)
        {
            bool estado = false;
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.COMPRA.Add(compra);
                    db.SaveChanges();
                    estado = true;
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    
                }

            }
            return estado;
            
        }

        public static void registrardetalles(COMPRADETA compradeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.COMPRADETA.Add(compradeta);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                }
                
            }
        }

        public static void mostrarcxp(DataGridView dataGrid)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from cxp in db.CUENTAXPAGAR
                               join compra in db.COMPRA
                               on cxp.COMPRA equals compra.ID
                               join prov in db.PROVEEDOR
                               on compra.PROVEEDOR equals prov.ID
                               select new
                               {
                                   cxp.IDCUENTA,
                                   prov.NOMBRE,
                                   compra.FECHACOMPRA,
                                   compra.FECHAPAGO,
                                   cxp.TOTAL,
                                   cxp.SALDO,
                                   cxp.ESTADO
                               };

                dataGrid.DataSource = consulta.ToList();
            }
        }

        public static void mostrarcxpabonos(DataGridView dataGrid, int idcuenta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from cxp in db.CXPABONO
                               where cxp.IDCXP == idcuenta
                               select new                               
                               {
                                   cxp.ID,
                                   cxp.FECHA,
                                   cxp.IMPORTE,
                                   cxp.NORECIBO
                               };

                dataGrid.DataSource = consulta.ToList();
            }
        }

        public static void filtrarcuentas(DataGridView dataGrid, string nombre)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from cxp in db.CUENTAXPAGAR
                               join compra in db.COMPRA
                               on cxp.COMPRA equals compra.ID
                               join prov in db.PROVEEDOR
                               on compra.PROVEEDOR equals prov.ID
                               where prov.NOMBRE.Contains(nombre)
                               select new
                               {
                                   cxp.IDCUENTA,
                                   prov.NOMBRE,
                                   compra.FECHACOMPRA,
                                   compra.FECHAPAGO,
                                   cxp.TOTAL,
                                   cxp.SALDO,
                                   cxp.ESTADO
                               };

                dataGrid.DataSource = consulta.ToList();
            }
        }

        public static void abonaracuenta(CXPABONO abono)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.CXPABONO.Add(abono);
                db.SaveChanges();
            }
        }
    }
}
