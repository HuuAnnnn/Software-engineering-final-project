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
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = Configuration.DB_DATA_SOURCE;
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = Configuration.DB_CATELOG;
            connection = new SqlConnection(builder.ConnectionString);
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
