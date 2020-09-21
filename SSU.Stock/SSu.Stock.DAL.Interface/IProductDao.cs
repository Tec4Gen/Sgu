using SSU.Stock.Entities;
using System.Collections.Generic;

namespace SSU.Stock.DAL.Interface
{
    public interface IProductDao
    {
        List<Product> GetAll();
        void Add(Product product);

        void DeleteById(int id);

        List<Product> FindByTitile(string title);
    }
}
