using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public ProductDAO(string productName, int quantityInStore, int quantityInWarehouse, string category, double price, byte[] image) 
        {
            string productId = generateProductId();
            this.product = new Product(productId, productName, quantityInStore, quantityInWarehouse, category, price, image);
            Connection.connect();
        }

        public ProductDAO(string productId, string productName, int quantityInStore, int quantityInWarehouse, string category, double price, byte[] image)
        {
            this.product = new Product(productId, productName, quantityInStore, quantityInWarehouse, category, price, image);
            Connection.connect();
        }

        public Product getProduct()
        {
            return this.product;
        }

        private int getNextProductId()
        {
            String query = "select top 1 productID from product order by productID desc";
            DataTable result = Connection.selectQuery(query);
            string currentId = "";
            if (result.Rows.Count > 0) 
            {
                foreach (DataRow row in result.Rows)
                {
                    currentId = row["productID"].ToString();
                    break;
                }

                int nextId = int.Parse(currentId.Substring(2)) + 1;
                return nextId;
            }

            return 1;
        }

        public string generateProductId()
        {
            int id = getNextProductId();
            return "SP" + ("" + id).PadLeft(3, '0');
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

        public DataTable selectQueryWithNameAndPrice(string productName, int price)
        {
            string selectQuery = "SELECT * FROM Product WHERE productName LIKE '%" + productName + "%' AND price <= " + price;
            return Connection.selectQuery(selectQuery);
        }
        public DataTable selectSortPriceDesc()
        {
            string selectQuery = "SELECT * FROM Product ORDER BY price Desc";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectSortPrice()
        {
            string selectQuery = "SELECT * FROM Product ORDER BY price";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable filterProductWithCategory(string category)
        {
            string selectQuery = "SELECT * FROM Product WHERE category = '" + category + "'";
            return Connection.selectQuery(selectQuery);
        }

        public Product getProductByID(string id)
        {
            string selectQuery = string.Format("SELECT * FROM PRODUCT WHERE PRODUCTID = '{0}'", id);
            DataTable result = Connection.selectQuery(selectQuery);
            Product product = null; 
            foreach (DataRow row in result.Rows)
            {
                product = new Product(
                    row["productId"].ToString(),
                    row["productName"].ToString(),
                    int.Parse(row["quantityInWareHouse"].ToString()),
                    int.Parse(row["quantityInStore"].ToString()),
                    row["category"].ToString(),
                    double.Parse(row["price"].ToString()),
                    null
                 );
            }

            return product;
        }
    }
}
