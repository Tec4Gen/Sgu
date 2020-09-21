using SSU.Stock.BLL.Interface;
using SSU.Stock.DAL;
using SSU.Stock.DAL.Interface;
using System;
using System.Collections.Generic;
namespace SSU.Stock.BLL
{
    public class StockLogic : IStockLogic
    {
        private IStockDao _stockDao;

        public StockLogic(IStockDao stockDao)
        {
            _stockDao = stockDao;
        }
        //Словарик для хранения всех акций из файла
        public void Add(SSU.Stock.Entities.Stock Stock)
        {
            _stockDao.Add(Stock);
        }

        public void DeleteById(int id)
        {
            _stockDao.DeleteById(id);
        }

        public List<SSU.Stock.Entities.Stock> FindByDate(DateTime date)
        {
            return _stockDao.FindByDate(date);
        }

        public List<SSU.Stock.Entities.Stock> GetAll()
        {
            return _stockDao.GetAll();
        }
    }
}
