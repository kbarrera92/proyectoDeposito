using Entidad;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Negocio
{
    public class Bs_Producto
    {
        public static int idproducto { get; set; }
        public static string nombreproducto { get; set; }
        public static decimal precio { get; set; }

        public static void crearProducto(PRODUCTO prod)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.PRODUCTO.Add(prod);
                db.SaveChanges();
            }
        }

        

        //GET COUNT
        public static int getcantidad()
        {
            int total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.PRODUCTO.Where(x=>x.ESTADO == true).Select(x => x.ID).Count();
                    total = Convert.ToInt32(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        //Obtener el valor del inventario
        public static decimal getvalorinventario()
        {
            decimal total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.PRODUCTO.Sum(x => x.EXISTENCIA * x.PRECIO);
                    total = Convert.ToDecimal(consulta);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return total;
        }

        public static void llenardgv(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from prod in db.PRODUCTO
                          where prod.ESTADO == true
                          select new
                          {
                              Codigo = prod.ID,
                              Descripcion = prod.DESCRIPCION,
                              Costo = prod.COSTO,
                              Precio = prod.PRECIO,
                              Presentacion = prod.PRESENTACION,
                              Marca = prod.MARCA,
                              Existencia = prod.EXISTENCIA,
                              StockMinimo = prod.STOCKMINIMO ?? 0.0m,
                              Retornable = prod.RETORNABLE
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void filtrardgv(DataGridView datagrid, string desc)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
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



        public static void actualizarProducto(int id, string desc, decimal costo, decimal precio, string pres, string marca, decimal existencia, bool ret, decimal stockMinimo)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from prod in db.PRODUCTO
                               where prod.ID.Equals(id)
                               select prod;

                foreach (var item in consulta)
                {
                    item.DESCRIPCION = desc;
                    item.COSTO = costo;
                    item.PRECIO = precio;
                    item.PRESENTACION = pres;
                    item.MARCA = marca;
                    item.EXISTENCIA = existencia;
                    item.RETORNABLE = ret;
                    item.STOCKMINIMO = stockMinimo;
                }


                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        public static void dardebajaproducto(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from prod in db.PRODUCTO
                               where prod.ID.Equals(id)
                               select prod;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }

        public static int ConsultaProductosConBajoStock()
        {
            int cantidadProductosStockBajo = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    cantidadProductosStockBajo = db.PRODUCTO.Count(p => p.EXISTENCIA < (p.STOCKMINIMO ?? 0));
                }
            }
            catch (Exception)
            {
                return 0;
            }
            

            return cantidadProductosStockBajo;
        }

        public static List<ProductoStockBajoDTO> ListaProductosConBajoStock()
        {
            List<PRODUCTO> lista = new List<PRODUCTO>();

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    return db.PRODUCTO
                             .Where(p => p.EXISTENCIA < p.STOCKMINIMO)
                             .Select(p => new ProductoStockBajoDTO
                             {
                                 ID = p.ID,
                                 DESCRIPCION = p.DESCRIPCION,
                                 EXISTENCIA = p.EXISTENCIA,
                                 STOCKMINIMO = p.STOCKMINIMO
                             })
                             .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
