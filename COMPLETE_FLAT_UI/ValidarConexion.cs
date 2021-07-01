using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{

     public class ValidarConexion
     {
        SqlConnection connection;

     public ValidarConexion(string connectionStrig)
     {
               connection = new SqlConnection(connectionStrig);
     }
     public bool Isconnection
     {
          get
          {
               if (connection.State == System.Data.ConnectionState.Closed)
                    if (connection != null)
                    {
                              connection.Open();
                         return true;
                    }
               return false;
          }

     }
  }
}
