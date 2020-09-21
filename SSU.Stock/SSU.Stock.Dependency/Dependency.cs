using SSU.Stock.BLL;
using SSU.Stock.BLL.Interface;
using SSU.Stock.DAL;
using SSU.Stock.DAL.Interface;

namespace SSU.Stock.Dependency
{
    public static class Dependency
    {
        private static IProductDao _productDao { get; set; } = new ProductDao();

        public static IProductLogic ClientLogic { get; set; } = new ProductLogic(_productDao);

        private static IStockDao _stockDao { get; set; } = new StockDao();

        public static IStockLogic StockLogic { get; set; } = new StockLogic(_stockDao);


    }
}
