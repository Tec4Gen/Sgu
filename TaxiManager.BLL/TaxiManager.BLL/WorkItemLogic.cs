using System;
using System.Collections.Generic;
using TaxiManager.DAL;
using TaxiManager.Entities;

namespace TaxiManager.BLL
{
    public class WorkItemLogic
    {
        private WorkItemDao _workItemDao = new WorkItemDao();
        public IEnumerable<WorkItem> GetAll()
        {
            return _workItemDao.GetAll();
        }

        public void Add(WorkItem car)
        {
            _workItemDao.Add(car);
        }
        public WorkItem GetById(int id)
        {
            return _workItemDao.GetById(id);
        }

        public void DeleteById(int id)
        {
            _workItemDao.DeleteById(id);
        }

        public void Show()
        {
            _workItemDao.Show();
        }

        public IEnumerable<WorkItem> GetByDate(DateTime date)
        {
           return _workItemDao.GetByDate(date);
        }

        public IEnumerable<WorkItem> GetByDateInterval(DateTime dateOne, DateTime dateTwo)
        {
            return _workItemDao.GetByDateInterval(dateOne, dateTwo);
        }
    }
}
