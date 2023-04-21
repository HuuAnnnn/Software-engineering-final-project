﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDAO productDAO;

        public ProductBUS() 
        {
            productDAO = new ProductDAO();
        }

        public ProductBUS(string productId, string productName, int quantityInStore, int quantityInWarehouse, string category, int price, byte[] image) 
        {
            this.productDAO = new ProductDAO(productId, productName, quantityInStore, quantityInWarehouse, category, price, image);
        }

        public void insertQuery()
        {
            this.productDAO.insertQuery();
        }

        public DataTable selectQuery()
        {
            return this.productDAO.selectQuery();
        }

        public DataTable selectQueryWithNameAndPrice(string productName, int price)
        {
            return this.productDAO.selectQueryWithNameAndPrice(productName, price);
        }
    }
}