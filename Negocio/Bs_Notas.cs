using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
namespace Negocio
{
    public class Bs_Notas
    {
        public static void crearNota(NOTAS cli)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.NOTAS.Add(cli);
                db.SaveChanges();
            }
        }
        public static void llenardgv(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from notas in db.NOTAS
                          select new
                          {
                              notas.ID,
                              notas.FECHA,
                              notas.CUERPO
                          };

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void borrar(int id)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from notas in db.NOTAS
                          where notas.ID == id
                          select notas;

                foreach (var item in lst)
                {
                    db.NOTAS.Remove(item);
                }

                db.SaveChanges();

            }
        }
    }
}
