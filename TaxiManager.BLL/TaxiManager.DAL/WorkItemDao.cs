using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TaxiManager.Entities;

namespace TaxiManager.DAL
{
    public class WorkItemDao
    {
        private string _connectionString = "WorkItemInfo.txt";

        private Dictionary<int, WorkItem> FakeDaoWorkItem;
        public IEnumerable<WorkItem> GetAll()
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                FakeDaoWorkItem = new Dictionary<int, WorkItem>();
                int index = 0;
                while (!files.EndOfStream)
                {

                    string line = files.ReadLine();
                    string[] data = line.Split(' ');

                    var driver = new Driver
                    {
                        FistName = data[2],
                        MiddleName = data[3],
                        LastName = data[4]
                    };

                    var car = new Car
                    {
                        Mark = data[4],
                    };



                    FakeDaoWorkItem.Add(index++, new WorkItem
                    {
                        WorkDate = DateTime.ParseExact(data[0], "MM/dd/yyyy", null),
                        Car = car,
                        Driver = driver
                    });
                }

                if (FakeDaoWorkItem.Any())
                {
                    return FakeDaoWorkItem.Select(x => x.Value);
                }
                return null;
            }
        }
        public WorkItem GetById(int id)
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                if (FakeDaoWorkItem.Any())
                {
                    return FakeDaoWorkItem.FirstOrDefault(x => x.Key == id).Value;
                }

                return null;
            }
        }

        public void Add(WorkItem workItem)
        {
            if (workItem == null)
                return;

            GetAll();
            if (FakeDaoWorkItem == null)
                return;

            using (StreamWriter files = new StreamWriter(_connectionString))
            {
                var lastIndex = FakeDaoWorkItem.LastOrDefault().Key;
                if (lastIndex == 0) 
                {
                    workItem.Id = lastIndex;
                    FakeDaoWorkItem.Add(lastIndex++, workItem);
                }
                else
                {
                    FakeDaoWorkItem.Add(++lastIndex, workItem);
                    workItem.Id = lastIndex;
                }
                   
                foreach (var item in FakeDaoWorkItem.Values)
                {
                    files.WriteLine($"{item.Id} {item.WorkDate.Date:MM/dd/yyyy} " +
                    $"{item.Driver.FistName} {item.Driver.MiddleName} {item.Driver.LastName} " +
                    $"{item.Car.Mark}");
                }
                
            }
        }

        public void DeleteById(int id)
        {

            GetAll();
            if (FakeDaoWorkItem == null || !FakeDaoWorkItem.Any())
                return;

            using (StreamWriter files = new StreamWriter(_connectionString, false))
            {
                if (!FakeDaoWorkItem.Remove(id))
                    return;

                foreach (var WorkItem in FakeDaoWorkItem.Values)
                {
                    files.WriteLine($"{WorkItem.Id} {WorkItem.WorkDate.Date:MM/dd/yyyy} " +
                   $"{WorkItem.Driver.LastName} {WorkItem.Driver.FistName} {WorkItem.Driver.MiddleName} " +
                   $"{WorkItem.Car.Mark}");
                }
            }
        }

        public void Show()
        {

            GetAll();
            if (FakeDaoWorkItem == null || !FakeDaoWorkItem.Any())
                return;

           
            foreach (var WorkItem in FakeDaoWorkItem)
            {
                Console.WriteLine($"{WorkItem.Key}: {WorkItem.Value.WorkDate.Date:MM/dd/yyyy} " +
                $"{WorkItem.Value.Driver.LastName} {WorkItem.Value.Driver.FistName} {WorkItem.Value.Driver.MiddleName} " +
                $"{WorkItem.Value.Car.Mark}");
            }

        }

        public IEnumerable<WorkItem> GetByDate(DateTime date) 
        {
            if (date == null)
                return null;

            GetAll();
            if (FakeDaoWorkItem == null || !FakeDaoWorkItem.Any())
                return null;

            var itemList = new List<WorkItem>();
            foreach (var item in FakeDaoWorkItem.Values)
            {
                if (date == item.WorkDate) 
                    itemList.Add(item);

            }

            return itemList;
        }

        public IEnumerable<WorkItem> GetByDateInterval(DateTime dateOne, DateTime dateTwo)
        {
            if (dateOne == null || dateTwo == null)
                return null;

            GetAll();
            if (FakeDaoWorkItem == null || !FakeDaoWorkItem.Any())
                return null;

            var itemList = new List<WorkItem>();
            foreach (var item in FakeDaoWorkItem.Values)
            {
                if (item.WorkDate >= dateOne && item.WorkDate <= dateTwo)
                    itemList.Add(item);

            }

            return itemList;
        }
    }
}
