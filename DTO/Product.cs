using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public Product(string productId, string productName, int quantityInStore, int quantityInWarehouse, int price)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.QuantityInStore = quantityInStore;
            this.QuantityInWarehouse = quantityInWarehouse;
            this.Price = price;
        }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public int QuantityInStore { get; set; }

        public int QuantityInWarehouse { get; set; }

        public int Price { get; set; }
    }
}
