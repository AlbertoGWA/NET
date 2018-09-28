using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND.Connections
{
    class SQLconnection
    {
        public static string ConnectionString() {
            return "DATA SOURCE = .; INITIAL CATALOG=NET; INTEGRATED SECURITY = SSPI; ";
        }

    }
}
