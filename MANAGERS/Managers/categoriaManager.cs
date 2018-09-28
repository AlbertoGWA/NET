using NORTHWND.Connections;
using NORTHWND.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NORTHWND.Managers
{
    public class categoriaManager
    {
        private SqlCommand Command = new SqlCommand();
        private List<categoriaModel> categorias = new List<categoriaModel>();
        public categoriaModel select(categoriaModel categoria)
        {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "SELECT_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@CATEGORY_ID", categoria.CategoryID);
                Command.Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoria = new categoriaModel
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            Description = (string)reader["Description"],
                            Picture = (byte[])reader["Picture"]
                        };
                    }
                }
                Command.Connection.Close();
                return categoria;
            }
        }
        public List<categoriaModel> selectAll()
        {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString())) {
                Command.Connection = connection;
                Command.CommandText = "SELECT_ALL_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                categorias.Clear();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        categorias.Add(new categoriaModel
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            Description = (string)reader["Description"],
                            Picture = (byte[])reader["Picture"]
                        });
                    }
                }
                Command.Connection.Close();
                return categorias;
            }
        }
        public int insert(categoriaModel categoria) {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "INSERT_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@CATEGORY_NAME",categoria.CategoryName);
                Command.Parameters.AddWithValue("@DESCRIPTION", categoria.Description);
                Command.Parameters.AddWithValue("@PICTURE", categoria.Picture);
                Command.Connection.Open();
                int affected = Command.ExecuteNonQuery();
                Command.Connection.Close();
                return affected;
            }
        }
        public int update(categoriaModel categoria) {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "UPDATE_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@CATEGORY_ID",categoria.CategoryID);
                Command.Parameters.AddWithValue("@CATEGORY_NAME",categoria.CategoryName);
                Command.Parameters.AddWithValue("@DESCRIPTION",categoria.Description);
                Command.Parameters.AddWithValue("@PICTURE",categoria.Picture);
                Command.Connection.Open();
                int affected = Command.ExecuteNonQuery();
                Command.Connection.Close();
                return affected;
            }
        }
        public int delete(categoriaModel categoria) {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "DELETE_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@CATEGORY_ID",categoria.CategoryID);
                Command.Connection.Open();
                int affected = Command.ExecuteNonQuery();
                Command.Connection.Close();
                return affected;
            }
        }
        public List<categoriaModel> searchName(categoriaModel categoria) {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "SEARCH_NAME_CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@CATEGORY_NAME", categoria.CategoryName);
                Command.Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                categorias.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categorias.Add(new categoriaModel
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            Description = (string)reader["Description"],
                            Picture = (byte[])reader["Picture"]
                        });
                    }
                }
                Command.Connection.Close();
                return categorias;
            }
        }

        public List<categoriaModel> searchDescription(categoriaModel categoria) {
            using (SqlConnection connection = new SqlConnection(SQLconnection.ConnectionString()))
            {
                Command.Connection = connection;
                Command.CommandText = "SEARCH_DESCRIPTION__CATEGORIES";
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@DESCRIPTION", categoria.Description);
                Command.Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                categorias.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categorias.Add(new categoriaModel
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"],
                            Description = (string)reader["Description"],
                            Picture = (byte[])reader["Picture"]
                        });
                    }
                }
                Command.Connection.Close();
                return categorias;
            }
        }
    }
}
