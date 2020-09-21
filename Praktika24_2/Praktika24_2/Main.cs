using Praktika24_1.Logic;
using Praktika24_1.Type;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Praktika24_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        ProductLogic ProductLogic = new ProductLogic();
        StockLogic StockLogic = new StockLogic();
        
        private void btnShowAllStock_Click(object sender, EventArgs e)
        {
            List<Stock> allAcii = StockLogic.GetAll();

            dataGridStock.Rows.Clear();

            foreach (var item in allAcii)
            {
                dataGridStock.Rows.Add(item.Id, item.Title, item.Date.ToString("MM/dd/yyyy"));
            }
        }

        private void TimeFindStock_Click(object sender, EventArgs e)
        {
            //DateTime date;
           
            DateTime dateFind = dateTimeFind.Value;
            try
            {
                //date = DateTime.ParseExact(dateFind, "MM/dd/yyyy", null);
                var listStock = StockLogic.FindByDate(dateFind);

                dataGridStock.Rows.Clear();

                foreach (var item in listStock)
                {
                    dataGridStock.Rows.Add(item.Id, item.Title, item.Date.ToString("MM/dd/yyyy"));
                }
            }
            catch
            {
                //Console.WriteLine("Введите нормальную дату: ММ/ДД/ГГГГ");
            }
            //Doto message
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textStockDeleteId.Text, out int idS))
            {
                StockLogic.DeleteById(idS);

                List<Stock> allAcii = StockLogic.GetAll();

                dataGridStock.Rows.Clear();

                foreach (var item in allAcii)
                {
                    dataGridStock.Rows.Add(item.Id, item.Title, item.Date.ToString("MM/dd/yyyy"));
                }

               
            }
            else
            {
                //Doto message
                //Console.WriteLine("Не верное id");
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
           
            string titleStock = textStockTitle.Text;
            DateTime dateString = dateTimeAdd.Value;

            try
            {
                //DateTime dateAdd = DateTime.ParseExact(dateString, "MM/dd/yyyy", null);
                Stock stock = new Stock
                {
                    Title = titleStock,
                    Date = dateString,
                };

                StockLogic.Add(stock);

                List<Stock> allAcii = StockLogic.GetAll();

                dataGridStock.Rows.Clear();

                foreach (var item in allAcii)
                {
                    dataGridStock.Rows.Add(item.Id, item.Title, item.Date.ToString("MM/dd/yyyy"));
                }
            }
            catch (Exception)
            {
                //todo
            }
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            List<Product> allProduct = ProductLogic.GetAll();

            dataGridProduct.Rows.Clear();

            foreach (var item in allProduct)
            {
                dataGridProduct.Rows.Add(item.Id, item.Title, item.Price);
            }
        }

        private void btnFindProductByTitle_Click(object sender, EventArgs e)
        {
            
            string titile = FindProductByTitle.Text;

            var findList = ProductLogic.FindByTitile(titile);
            if (findList != null)
            {
                dataGridProduct.Rows.Clear();

                foreach (var item in findList)
                {
                    dataGridProduct.Rows.Add(item.Id, item.Title, item.Price);
                }
                return;
            }
            dataGridProduct.Rows.Clear();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textProductDeleteId.Text, out int idS))
            {
                ProductLogic.DeleteById(idS);

                List<Product> allProduct = ProductLogic.GetAll();

                dataGridProduct.Rows.Clear();

                foreach (var item in allProduct)
                {
                    dataGridProduct.Rows.Add(item.Id, item.Title, item.Price);
                }
            }
            else
            {
                //Doto message
                //Console.WriteLine("Не верное id");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string title = textProductTitle.Text;
            
            if (int.TryParse(textProductPrice.Text, out int Price))
            {
                Product product = new Product
                {
                    Price = Price,
                    Title = title,
                };

                ProductLogic.Add(product);

                List<Product> allProduct = ProductLogic.GetAll();

                dataGridProduct.Rows.Clear();

                foreach (var item in allProduct)
                {
                    dataGridProduct.Rows.Add(item.Id, item.Title, item.Price);
                }
            }
        }
    }
}
