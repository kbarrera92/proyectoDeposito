using System;
using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Negocio
{
    public class ClaveUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public bool TieneClave1 { get; set; }
        public bool TieneClave2 { get; set; }
    }

    public class Bs_ClaveAcceso
    {
        public const string CONFIGCAPITAL = "CONFIGCAPITAL";
        public const string DASHBOARD = "DASHBOARD";
        public const string INVENTARIO = "INVENTARIO";
        public const string MOVIMIENTOS = "MOVIMIENTOS";
        public const string DASHBOARDADMIN = "DASHBOARDADMIN";
        public const string CONFIGCLAVES = "CONFIGCLAVES";

        private const short TIPO_ADMIN = 100;

        /// <summary>
        /// Valida la clave ingresada contra la clave (1 o 2) asignada a la pantalla,
        /// tomada del usuario logueado. Si la Clave 1 del usuario no está definida
        /// se usa su contraseña de inicio de sesión.
        /// </summary>
        public static bool validarClave(string pantalla, string ingresada)
        {
            if (string.IsNullOrEmpty(ingresada) || Bs_Usuario.usuarioActual == 0)
            {
                return false;
            }

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var asignacion = db.PANTALLACLAVE.FirstOrDefault(p => p.PANTALLA == pantalla);
                short tipo = asignacion != null ? asignacion.TIPOCLAVE : (short)1;

                int idUsuario = Bs_Usuario.usuarioActual;
                var user = db.USUARIO.FirstOrDefault(u => u.ID == idUsuario);
                if (user == null)
                {
                    return false;
                }

                string esperada;
                if (tipo == 2)
                {
                    esperada = user.CLAVE2;
                }
                else
                {
                    esperada = string.IsNullOrEmpty(user.CLAVE1) ? user.PASSWORD : user.CLAVE1;
                }

                return !string.IsNullOrEmpty(esperada) && esperada == ingresada;
            }
        }

        public static List<ClaveUsuario> obtenerAdmins()
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                // Clave 1 vacía cae en la contraseña de inicio de sesión, por lo que siempre está definida
                return db.USUARIO
                    .Where(u => u.ESTADO == true && u.TIPOUSUARIO == TIPO_ADMIN)
                    .OrderBy(u => u.NOMBRE)
                    .Select(u => new ClaveUsuario
                    {
                        Id = u.ID,
                        Nombre = u.NOMBRE,
                        Usuario = u.USER,
                        TieneClave1 = (u.CLAVE1 != null && u.CLAVE1 != "") || (u.PASSWORD != null && u.PASSWORD != ""),
                        TieneClave2 = u.CLAVE2 != null && u.CLAVE2 != ""
                    }).ToList();
            }
        }

        /// <summary>
        /// Guarda las claves de un administrador. Una clave nula o vacía conserva la actual.
        /// Devuelve el mensaje de error, o null si se guardó correctamente.
        /// </summary>
        public static string guardarClavesAdmin(int id, string clave1, string clave2)
        {
            clave1 = string.IsNullOrWhiteSpace(clave1) ? null : clave1.Trim();
            clave2 = string.IsNullOrWhiteSpace(clave2) ? null : clave2.Trim();

            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var user = db.USUARIO.FirstOrDefault(u => u.ID == id && u.TIPOUSUARIO == TIPO_ADMIN);
                if (user == null)
                {
                    return "No se encontró el usuario administrador";
                }

                string final1 = clave1 ?? (string.IsNullOrEmpty(user.CLAVE1) ? user.PASSWORD : user.CLAVE1);
                string final2 = clave2 ?? user.CLAVE2;

                if (!string.IsNullOrEmpty(final2) && final1 == final2)
                {
                    return "La Clave 1 y la Clave 2 deben ser diferentes";
                }

                if (clave1 != null)
                {
                    user.CLAVE1 = clave1;
                }
                if (clave2 != null)
                {
                    user.CLAVE2 = clave2;
                }
                db.SaveChanges();
                return null;
            }
        }

        public static PANTALLACLAVE obtenerPantalla(string pantalla)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                return db.PANTALLACLAVE.FirstOrDefault(p => p.PANTALLA == pantalla);
            }
        }

        public static List<PANTALLACLAVE> obtenerPantallas()
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                return db.PANTALLACLAVE.OrderBy(p => p.DESCRIPCION).ToList();
            }
        }

        public static void guardarAsignaciones(Dictionary<string, short> asignaciones)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                foreach (var par in asignaciones)
                {
                    var pantalla = db.PANTALLACLAVE.FirstOrDefault(p => p.PANTALLA == par.Key);
                    if (pantalla != null)
                    {
                        pantalla.TIPOCLAVE = par.Value;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
