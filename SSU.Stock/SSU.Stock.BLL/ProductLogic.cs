
using SSU.Stock.BLL.Interface;
using SSU.Stock.DAL;
using SSU.Stock.DAL.Interface;
using SSU.Stock.Entities;
using System.Collections.Generic;

namespace SSU.Stock.BLL
{
    public class ProductLogic : IProductLogic
    {
        private IProductDao _stockDao;

        public ProductLogic(IProductDao stockDao)
        {
            _stockDao = stockDao;
        }
        public void Add(Product product)
        {
            _stockDao.Add(product);
        }

        public void DeleteById(int id)
        {
            _stockDao.DeleteById(id);
        }

        public List<Product> FindByTitile(string title)
        {
            return _stockDao.FindByTitile(title);
        }

        public List<Product> GetAll()
        {
            return _stockDao.GetAll();
        }
    }
}

