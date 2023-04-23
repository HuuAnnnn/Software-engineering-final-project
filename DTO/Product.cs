using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public Product() { }    
        public Product(string productId, string productName, int quantityInStore, int quantityInWarehouse,string category, double price, byte[] image)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.QuantityInStore = quantityInStore;
            this.QuantityInWarehouse = quantityInWarehouse;
            this.Category= category;
            this.Price = price;
            this.Image = image;
        }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public int QuantityInStore { get; set; }

        public int QuantityInWarehouse { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public byte[] Image { get; set; }
    }
}
