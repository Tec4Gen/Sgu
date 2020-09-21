using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSU.Stock.Entities;
namespace SSU.Stock.DAL.Interface
{
    public interface IStockDao
    {
        List<SSU.Stock.Entities.Stock> GetAll();
        //Добавляем товары 
        void Add(SSU.Stock.Entities.Stock Stock);

        void DeleteById(int id);

        List<SSU.Stock.Entities.Stock> FindByDate(DateTime date);
    }
}

