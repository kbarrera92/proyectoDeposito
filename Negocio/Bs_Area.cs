using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Negocio
{
    public class Bs_Area
    {
        public static void crearArea(AREAREPARTO user)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.AREAREPARTO.Add(user);
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
                    var consulta = db.AREAREPARTO.Where(x=>x.ESTADO==true).Select(x => x.ID).Count();
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
                var lst = from a in db.AREAREPARTO
                          where a.ESTADO == true
                          select new
                          {
                              Id = a.ID,
                              Codigo = a.CODIGO,
                              Nombre = a.NOMBRE
                              
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void actualizarUsuario(int id, string codigo, string nombre)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from areas in db.AREAREPARTO
                               where areas.ID.Equals(id)
                               select areas;

                foreach (var item in consulta)
                {
                    item.NOMBRE = nombre;
                    item.CODIGO = codigo;
                   
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void dardebajausuario(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from areas in db.AREAREPARTO
                               where areas.ID.Equals(id)
                               select areas;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }
    }
}
