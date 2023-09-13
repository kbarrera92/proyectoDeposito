using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Negocio
{
    public class Bs_Proveedor
    {
        public static void crearProveedor(PROVEEDOR prov)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.PROVEEDOR.Add(prov);
                db.SaveChanges();
            }
        }

        public static int getcantidad()
        {
            int total = 0;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    var consulta = db.PROVEEDOR.Where(x=>x.ESTADO==true).Select(x => x.ID).Count();
                    total = Convert.ToInt32(consulta);
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
                var lst = from u in db.PROVEEDOR
                          where u.ESTADO == true
                          select new
                          {
                              Codigo = u.ID,
                              NIT = u.NIT,
                              Nombre = u.NOMBRE,
                              Direccion = u.DIRECCION,
                              Telefono = u.TELEFONO,
                              Contacto = u.CONTACTO
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void actualizarProveedor(int id, string nit, string nombre, string direccion, string tele, string contacto)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from prov in db.PROVEEDOR
                               where prov.ID.Equals(id)
                               select prov;

                foreach (var item in consulta)
                {
                    item.NOMBRE = nombre;
                    item.NIT = nit;
                    item.DIRECCION = direccion;
                    item.TELEFONO = tele;
                    item.CONTACTO = contacto;
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void dardebajaproveedor(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from prov in db.PROVEEDOR
                               where prov.ID.Equals(id)
                               select prov;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }
    }
}
