using System;
using System.Linq;
using System.Windows.Forms;
using Entidad;

namespace Negocio
{
    public class Bs_Cliente
    {
        public static int idcliente { get; set; }
        public static string codigocliente { get; set; }
        public static string nombrecliente { get; set; }
        public static double saldo { get; set; }
        public static void crearCliente(CLIENTE cli)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.CLIENTE.Add(cli);
                db.SaveChanges();
            }
        }

        public static void crearhistorialsaldos(BIT_ABONOSYSALDOS bitacora)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.BIT_ABONOSYSALDOS.Add(bitacora);
                    db.SaveChanges();
                    
                }
                catch (Exception ex)
                {
                    throw;
                    //MessageBox.Show(ex.Message);
                }
                
            }
        }

        //Obtener la cantidad de saldo de todos los clientes
        public static decimal gettotalsaldo()
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.CLIENTE.Where(x=>x.ESTADO == true).Sum(x => x.SALDO);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Obtener la cantidad de clientes
        public static int getcantidad()
        {
            int total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.CLIENTE.Where(x=>x.ESTADO==true).Select(x => x.ID).Count();
                    total = Convert.ToInt32(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        

        

        

        

        public static decimal obtenersaldo(int id)
        {
            decimal saldo = 0.0m;

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                
                var query = (from cliente in db.CLIENTE
                            where cliente.ID.Equals(id)
                            select cliente.SALDO).ToList();

                foreach (var item in query)
                {
                    saldo = decimal.Parse(item.ToString());
                }
                
            }

            return saldo;
        }

        public static decimal obtenerSaldoAnterior(int id)
        {
            decimal saldo = 0.0m;

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {

                var query = db.CLIENTE.Where(x => x.ID == id).Select(x => x.SALDOANTERIOR);
                saldo = decimal.Parse(query.FirstOrDefault().ToString());
            }

            return saldo;
        }

        public static void llenardgv(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from cli in db.CLIENTE
                          join area in db.AREAREPARTO
                          on cli.AREAREPARTO equals area.ID  
                          where cli.ESTADO == true
                          orderby cli.CODIGO descending
                          select new
                          {
                              Id = cli.ID,
                              Codigo = cli.CODIGO,
                              Nombre = cli.NOMBRE,
                              Area = area.NOMBRE,
                              Direccion = cli.DIRECCION == null ? "" : cli.DIRECCION,
                              Telefono = cli.TELEFONO == null ? "" : cli.TELEFONO,
                              Saldo = cli.SALDO
                          };
                                
                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenardgvabonos(DataGridView datagrid, int cliente)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from abono in db.BIT_ABONOSYSALDOS
                          join cli in db.CLIENTE on abono.IDCLUENTE equals cli.ID
                          where cli.ID == cliente
                          select new
                          {
                              abono.ID,
                              abono.FECHA,
                              cli.NOMBRE,
                              abono.TOTAL,
                              abono.COBRADO,
                              abono.SALDO,
                              abono.REPARTIDOR
                          };

                var lst2 = from lista1 in lst
                    join rep in db.REPARTIDOR on lista1.REPARTIDOR equals rep.ID into rep
                    from repartidor in rep.DefaultIfEmpty()
                    orderby lista1.FECHA ascending
                    select new
                    {
                        lista1.ID,
                        lista1.FECHA,
                        lista1.NOMBRE,
                        lista1.TOTAL,
                        lista1.COBRADO,
                        lista1.SALDO,
                        REPARTIDOR = repartidor.NOMBRE
                    };

               datagrid.DataSource = lst2.ToList();

            }
        }

        //Filtrar x nombre
        public static void filtrarxnombre(DataGridView datagrid, string nombre)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from cli in db.CLIENTE
                          join area in db.AREAREPARTO
                          on cli.AREAREPARTO equals area.ID
                          where cli.ESTADO == true && cli.NOMBRE == nombre
                          select new
                          {
                              Id = cli.ID,
                              Codigo = cli.CODIGO,
                              Nombre = cli.NOMBRE,
                              Area = area.NOMBRE,
                              Direccion = cli.DIRECCION == null ? "" : cli.DIRECCION,
                              Telefono = cli.TELEFONO == null ? "" : cli.TELEFONO,
                              Saldo = cli.SALDO
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        //Filtrar x area
        public static void filtrarxarea(DataGridView datagrid, string a)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from cli in db.CLIENTE
                          join area in db.AREAREPARTO
                          on cli.AREAREPARTO equals area.ID
                          where cli.ESTADO == true && area.NOMBRE == a
                          select new
                          {
                              Id = cli.ID,
                              Codigo = cli.CODIGO,
                              Nombre = cli.NOMBRE,
                              Area = area.NOMBRE,
                              Direccion = cli.DIRECCION == null ? "" : cli.DIRECCION,
                              Telefono = cli.TELEFONO == null ? "" : cli.TELEFONO,
                              Saldo = cli.SALDO
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenarcmb(ComboBox combo)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.AREAREPARTO
                          where a.ESTADO == true
                          select new
                          {
                              Codigo = a.ID,
                              Area = a.NOMBRE
                              
                          }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Area";

            }
        }

        public static void llenarcmbclientefiltro(ListBox combo, string clien)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.CLIENTE                           
                           where a.ESTADO == true && a.NOMBRE.Contains(clien)
                           select new
                           {
                               Codigo = a.ID,
                               Nombre = a.NOMBRE

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";

            }
        }

        public static void llenarcmbcliente(ListBox combo, string area)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.CLIENTE
                           join rep in db.AREAREPARTO
                           on a.AREAREPARTO equals rep.ID
                           where a.ESTADO == true && rep.NOMBRE.Equals(area)
                           select new
                           {
                               Codigo = a.ID,
                               Nombre = a.NOMBRE

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";

            }
        }


        public static void llenarcmbclientetodos(ListBox combo)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.CLIENTE                           
                           where a.ESTADO == true
                           select new
                           {
                               Codigo = a.ID,
                               Nombre = a.NOMBRE

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";

            }
        }

        public static void llenarcmbcliente1(ComboBox combo, string area)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.CLIENTE
                           join rep in db.AREAREPARTO
                           on a.AREAREPARTO equals rep.ID
                           where a.ESTADO == true && rep.NOMBRE.Equals(area)
                           select new
                           {
                               Codigo = a.ID,
                               Nombre = a.NOMBRE

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";

            }
        }

        public static void actualizarCliente(int id, string codigo, string nombre, int area, string direccion, string tele, decimal saldo)
        {
            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = from cli in db.CLIENTE
                                   where cli.ID.Equals(id)
                                   select cli;

                    foreach (var item in consulta)
                    {
                        item.CODIGO = codigo;
                        item.NOMBRE = nombre;
                        item.AREAREPARTO = area;
                        item.DIRECCION = direccion;
                        item.TELEFONO = tele;
                        item.SALDO = saldo;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void dardebajacliente(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from cli in db.CLIENTE
                               where cli.ID.Equals(id)
                               select cli;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }

        

        public static void llenartodoslospedidos(int cliente, DataGridView datagrid, DateTime ini, DateTime fin)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                
                var consultapedido = db.PEDIDO
                                       .Join(db.PEDIDODETA, ped => ped.ID, peddeta => peddeta.IDPEDIDO, (ped, peddeta) => new { ped, peddeta })
                                       .Join(db.PRODUCTO, x => x.peddeta.IDPRODUCTO, prod => prod.ID, (x, prod) => new { x, prod })
                                       .Where(n => n.x.ped.FECHA >= ini.Date && n.x.ped.FECHA <= fin.Date && n.x.ped.CLIENTE == cliente)
                                       .Select(m => new ListaPedidos
                                       {
                                           FECHA = m.x.ped.FECHA.Value,
                                           DESCRIPCION = m.prod.DESCRIPCION,
                                           CANTIDAD = m.x.peddeta.CANTIDAD.Value,
                                           SUBTOTAL = m.x.peddeta.SUBTOTAL.Value
                                       }).Union(
                                            db.AUTOVENTA
                                            .Join(db.AUTOVENTADETA2, aut => aut.ID, av => av.IDAUTOVENTA, (aut, av) => new { aut, av})
                                            .Join(db.PRODUCTO, x => x.av.IDPRODUCTO, prod => prod.ID, (x, prod) => new { x, prod })
                                            .Where(n => n.x.aut.FECHA >= ini.Date && n.x.aut.FECHA <= fin.Date && n.x.av.CLIENTE == cliente)
                                            .Select(m => new ListaPedidos
                                            {
                                                FECHA = m.x.aut.FECHA.Value,
                                                DESCRIPCION = m.prod.DESCRIPCION,
                                                CANTIDAD = m.x.av.CANTIDAD,
                                                SUBTOTAL = m.x.av.PRECIO
                                            })
                                        );                                      
                                
                datagrid.DataSource = consultapedido.ToList();                         
                
            }
        }

    }
}
