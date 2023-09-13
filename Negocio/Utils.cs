using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Utils
    {
        public static string ConsultaParametro(string parametro)
        {
            var retValue = string.Empty;
            try
            {
                var appSetting = ConfigurationManager.AppSettings;
                retValue = appSetting[parametro] ?? string.Empty;
            }
            catch (ConfigurationErrorsException e)
            {
                retValue = string.Empty;
            }

            return retValue;
        }
    }
}
