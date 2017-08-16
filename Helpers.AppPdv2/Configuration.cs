using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.AppPdv2
{
    public class Configuration
    {
        public Configuration()
        {

        }

        public string GetConfigurationName(string chave)
        {
            return ConfigurationManager.AppSettings[chave];
        }

        public string GetConnectString(string chave)
        {
            return ConfigurationManager.ConnectionStrings[chave].ConnectionString;
        }

    }
}
