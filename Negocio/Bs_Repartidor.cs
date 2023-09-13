using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Negocio
{
    public class Bs_Repartidor
    {
        public static void crearRepartidor(REPARTIDOR rep)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.REPARTIDOR.Add(rep);
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
                    var consulta = db.REPARTIDOR.Where(x=>x.ESTADO==true).Select(x => x.ID).Count();
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
                var lst = from u in db.REPARTIDOR
                          where u.ESTADO == true
                          select new
                          {
                              Codigo = u.ID,
                              Nombre = u.NOMBRE,
                              Usuario = u.TELEFONO,
                              
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void llenarcmb(ComboBox combo)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from u in db.REPARTIDOR
                          where u.ESTADO == true
                          select new
                          {
                              Codigo = u.ID,
                              Nombre = u.NOMBRE,
                              
                          };

                combo.DataSource = lst.ToList();
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Codigo";

            }
        }

        public static void actualizarRepartidor(int id, string nombre, string tele)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from rep in db.REPARTIDOR
                               where rep.ID.Equals(id)
                               select rep;

                foreach (var item in consulta)
                {
                    item.NOMBRE = nombre;
                    item.TELEFONO = tele;
                   
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void dardebajarepartidor(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from reps in db.REPARTIDOR
                               where reps.ID.Equals(id)
                               select reps;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }
    }
}
