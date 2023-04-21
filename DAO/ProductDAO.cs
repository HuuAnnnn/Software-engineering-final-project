using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAO
{
    public class ProductDAO
    {
        private Product product;

        public ProductDAO()
        {
            this.product = new Product();
            Connection.connect();
        }
        public ProductDAO(string productId, string productName, int quantityInStore, int quantityInWarehouse, string category, int price, byte[] image) 
        {
            this.product = new Product(productId, productName, quantityInStore, quantityInWarehouse, category, price, image);
            Connection.connect();
        }

        public void insertQuery()
        {
            string query = "INSERT INTO Product VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7)";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.Add("@val1", SqlDbType.NVarChar, 50);
            command.Parameters["@val1"].Value = product.ProductId;
            command.Parameters.Add("@val2", SqlDbType.NVarChar, 50);
            command.Parameters["@val2"].Value = product.ProductName;
            command.Parameters.Add("@val3", SqlDbType.Int);
            command.Parameters["@val3"].Value = product.QuantityInWarehouse;
            command.Parameters.Add("@val4", SqlDbType.Int);
            command.Parameters["@val4"].Value = product.QuantityInStore;
            command.Parameters.Add("@val5", SqlDbType.NVarChar, 50);
            command.Parameters["@val5"].Value = product.Category;
            command.Parameters.Add("@val6", SqlDbType.Int);
            command.Parameters["@val6"].Value = product.Price;
            command.Parameters.Add("@val7", SqlDbType.Image, int.MaxValue);
            command.Parameters["@val7"].Value = product.Image;
            Connection.actionQuery(command);
        }

        public DataTable selectQuery()
        {
            string selectQuery = "SELECT * FROM Product";
            return Connection.selectQuery(selectQuery);
        } 
    }
}
