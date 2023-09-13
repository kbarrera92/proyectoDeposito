using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Windows.Forms;

namespace Negocio
{
    public class Bs_Ajuste
    {
        public static bool registrarajuste(AJUSTE ajuste)
        {
            bool estado = false;

            try
            {
                using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
                {
                    db.AJUSTE.Add(ajuste);
                    db.SaveChanges();
                    estado = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
            }

            return estado;
        }

        public static void registrardetallespedido(AJUSTEDETA ajustedeta)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                try
                {
                    db.AJUSTEDETA.Add(ajustedeta);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
