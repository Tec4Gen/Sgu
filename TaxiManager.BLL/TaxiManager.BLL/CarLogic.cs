using System.Collections.Generic;
using TaxiManager.DAL;
using TaxiManager.Entities;

namespace TaxiManager.BLL
{
    public class CarLogic
    {
        private CarDao _carDao = new CarDao();
        public IEnumerable<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public void Add(Car car)
        {
            _carDao.Add(car);
        }

        public Car GetById(int id)
        {
            return _carDao.GetById(id);
        }

        public IEnumerable<Car> FindByMark(string mark)
        {
            return _carDao.FindByMark(mark);
        }

        public void DeleteById(int id)
        {
            _carDao.DeleteById(id);
        }

        public void Show()
        {
            _carDao.Show();
        }
    }
}
