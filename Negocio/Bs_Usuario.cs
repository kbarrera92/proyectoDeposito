using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Negocio
{
    public class Bs_Usuario
    {
        public static int usuarioActual;
        public static string password { get; set; }
        public static bool isAdmin;
        

        public static bool checkLogin(string user, string pass)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var lst = from u in db.USUARIO
                          where u.USER == user
                          && u.PASSWORD == pass
                          select new { u.ID, u.PASSWORD, u.TIPOUSUARIO };

                foreach (var item in lst)
                {
                    usuarioActual = item.ID;
                    password = item.PASSWORD;
                    isAdmin = item.TIPOUSUARIO == 100;
                }

                if (lst.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public static void crearUsuario(USUARIO user)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                db.USUARIO.Add(user);
                db.SaveChanges();
            }
        }

        public static void llenardgv(DataGridView datagrid)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = from u in db.USUARIO
                          where u.ESTADO == true
                          select new
                          {
                              Codigo = u.ID,
                              Nombre = u.NOMBRE,
                              Usuario = u.USER,
                              Contra = u.PASSWORD
                          }; 

                datagrid.DataSource = lst.ToList();

            }
        }

        public static void actualizarUsuario(int id, string nombre, string usuario, string password)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from users in db.USUARIO
                               where users.ID.Equals(id)
                               select users;

                foreach (var item in consulta)
                {
                    item.NOMBRE = nombre;
                    item.USER = usuario;
                    item.PASSWORD = password;
                }

                db.SaveChanges();
                MessageBox.Show("Registro actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void dardebajausuario(int id)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var consulta = from users in db.USUARIO
                               where users.ID.Equals(id)
                               select users;

                foreach (var item in consulta)
                {
                    item.ESTADO = false;
                }

                db.SaveChanges();
            }
        }

       public static void llenarCmbTipoUsuario(ComboBox combo)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.TIPOUSUARIO                           
                           select new
                           {
                               Codigo = a.IDTIPO,
                               Nombre = a.DESCRIPCION

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";

            }
        } 
    }
}
