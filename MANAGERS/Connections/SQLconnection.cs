using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGERS.Connections
{
    class SQLconnection
    {
        private SQLconnection connection;
        SQLconnection() {
            connection = new SQLconnection().connection("INTEGRATED SECURITY = SSPI; INITIAL CATALOG=NORTHWND; DATA SOURCE = .;");
        }
        public static string returnSQLConnection() {
            return "";
        }

    }
}
