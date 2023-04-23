using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class StatisticForm : Form
    {
        private ReceiptBUS receiptBUS;
        public StatisticForm()
        {
            InitializeComponent();
            receiptBUS = new ReceiptBUS();
        }

        public string formatDate(string date)
        {
            string[] timeArray = date.Split(' ');
            string[] dateArray = timeArray[0].Split('/');
            if (dateArray.Length == 1)
            {
                dateArray = timeArray[0].Split('-');
            }
            string day = dateArray[1];
            string month = dateArray[0];
            string year = dateArray[2];
            return year + "-" + month + "-" + day;
        }
        private void btnStatisticRevenue_Click(object sender, EventArgs e)
        {
            string startDate = formatDate(dtpStartDate.Value.ToString("dd/MM/yyyyy"));
            string endDate = formatDate(dtpEndDate.Value.ToString("dd/MM/yyyyy"));
            statisticRevenue(startDate, endDate);
        }

        public void statisticRevenue(string startDate, string endDate)
        {
            DataTable tableRevenueInDay = receiptBUS.selectTotalRevenueInDay(startDate, endDate);

            if (tableRevenueInDay.Rows.Count <= 10)
            {
                string time = "";
                string label = "";
                int value = 0;
                foreach (DataRow row in tableRevenueInDay.Select())
                {
                    time = Convert.ToDateTime(row["dateCreated"]).ToString();
                    label = time.Split(' ')[0];
                    value = Convert.ToInt32(row["totalInDay"]);
                    charRevenue.Series["Revenue"].Points.AddXY(label, value);
                }
            }
            else
            {
                List<DataTable> tables = splitTable(tableRevenueInDay, 10);
                string time = "";
                string firstDate = "";
                int value = 0;
                foreach (DataTable table in tables)
                {
                    time = Convert.ToDateTime(table.Rows[0]["dateCreated"]).ToString();
                    firstDate = time.Split(' ')[0];
                    value = getRevenueInBatch(table);
                    charRevenue.Series["Revenue"].Points.AddXY(firstDate, value);
                }
            }
        }

        private static List<DataTable> splitTable(DataTable mainTable, int batchSize)
        {
            List<DataTable> tables = new List<DataTable>();
            int i = 0;
            int j = 1;
            int rowCount = 0;
            DataTable tempDataTable = mainTable.Clone();
            tempDataTable.TableName = "ChunkDataTable" + j.ToString();
            tempDataTable.Clear();
            foreach (DataRow row in mainTable.Rows)
            {
                rowCount += 1;
                DataRow newRow = tempDataTable.NewRow();
                newRow.ItemArray = row.ItemArray;
                tempDataTable.Rows.Add(newRow);
                i += 1;
                if (i == batchSize | rowCount == mainTable.Rows.Count)
                {
                    tables.Add(tempDataTable);
                    j += 1;
                    tempDataTable = mainTable.Clone();
                    tempDataTable.TableName = "ChunkDataTable" + j.ToString();
                    tempDataTable.Clear();
                    i = 0;
                }
            }
            return tables;
        }

        private int getRevenueInBatch(DataTable table)
        {
            int revenue = 0;

            foreach(DataRow row in table.Select())
            {
                revenue += Convert.ToInt32(row["totalInDay"]);
            }

            return revenue;
        }

        private void btnStatisticProduct_Click(object sender, EventArgs e)
        {
            string startDate = formatDate(dtpStartDate.Value.ToString());
            string endDate = formatDate(dtpEndDate.Value.ToString());
            statisticProduct(startDate, endDate);
        }

        public void statisticProduct(string startDate, string endDate)
        {
            DataTable top10Product = receiptBUS.selectTop10Product(startDate, endDate);
            charProduct.Titles.Add("Top 10 Product");
            string label = "";
            int value = 0;
            foreach (DataRow row in top10Product.Select())
            {
                label = row["productName"].ToString();
                value = Convert.ToInt32(row["totalOfProduct"].ToString());
                charProduct.Series["Series1"].Points.AddXY(label, value);
            } 
        }
    }
}
