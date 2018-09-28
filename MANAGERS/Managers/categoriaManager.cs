using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGERS.Managers
{
    class categoriaManager
    {
        private Connections.SQLconnection SQLconnection;
        private Models.categoriaModel categoriaModel;
        private System.Data.SqlClient.SqlCommand Command;
        public void select()
        {
            loConn.Open()
            loComm.Connection = loConn
            loComm.CommandText = "Ayuda_Producto"
            loComm.CommandType = CommandType.StoredProcedure
            loComm.Parameters.Clear()
            loComm.Parameters.Add(New SqlParameter("@PROD_DESC", TxtProdDes.Text))
            loDR = loComm.ExecuteReader();

            Command.Connection = SQLconnection();
            Command.CommandText = "";
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("",);

        }
        public void selectAll()
        {

        }
        public void insert() { }
        public void update() { }
        public void delete() { }
    }
}
