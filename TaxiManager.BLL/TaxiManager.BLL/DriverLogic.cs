using System.Collections.Generic;
using TaxiManager.DAL;
using TaxiManager.Entities;

namespace TaxiManager.BLL
{
    public class DriverLogic
    {
        private DriverDao _driverDao = new DriverDao();
        public IEnumerable<Driver> GetAll()
        {
            return _driverDao.GetAll();
        }

        public void Add(Driver car)
        {
            _driverDao.Add(car);
        }
        public Driver GetById(int id)
        {
            return _driverDao.GetById(id);
        }

        public void DeleteById(int id)
        {
            _driverDao.DeleteById(id);
        }
        public IEnumerable<Driver> FindByLastName(string lastName)
        {
            return _driverDao.FindByLastName(lastName);
        }
        public void Show()
        {
            _driverDao.Show();
        }
    }
}
