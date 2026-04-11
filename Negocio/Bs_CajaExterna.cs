using Entidad;
using System;
using System.Linq;

namespace Negocio
{
    public static class Bs_CajaExterna
    {
        public static decimal GetLastBalance(DEPOSITOEntities1 context)
        {
            try
            {
                var balance = context.CAJAEXTERNA.OrderByDescending(x => x.ID).Select(x => x.SALDO).FirstOrDefault();
                return balance;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool SaveTransactionCajaExterna(CAJAEXTERNA caja)
        {
            try
            {
                using (var db = new DEPOSITOEntities1())
                {
                    var balance = GetLastBalance(db);
                    caja.SALDO = balance + caja.IMPORTE;
                    db.CAJAEXTERNA.Add(caja);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
                
    }
}
