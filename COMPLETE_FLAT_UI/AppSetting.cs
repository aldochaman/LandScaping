using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace COMPLETE_FLAT_UI
{
     class AppSetting
     {
          Configuration config;
          public AppSetting()
          {
               config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

          }
          public string GetConnectionString(string key)
          {
               return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
          }
          public void SaveConnectionString(string key, string value)
          {
               config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
               config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
               config.Save(ConfigurationSaveMode.Modified);
          }
     }
}
