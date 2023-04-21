using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace DAO
{
    public static class Connection
    {
        private static SqlConnection connection;
        public static void connect()
        {
            string connectionString = "initial catalog = QuanLyCuaHangDungCuTheThao; " +
                                        "data source = THINHVO\\SQLEXPRESS; " +
                                        "integrated security=true";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static void actionQuery(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = connection;
            sqlCommand.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string query)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
