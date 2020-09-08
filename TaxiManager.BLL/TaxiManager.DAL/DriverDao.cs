using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TaxiManager.Entities;

namespace TaxiManager.DAL
{
    public class DriverDao
    {
        private string _connectionString = "DriverInfo.txt";

        private Dictionary<int, Driver> FakeDaoDriver;
        public IEnumerable<Driver> GetAll()
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                FakeDaoDriver = new Dictionary<int, Driver>();
                int index = 0;

                while (!files.EndOfStream)
                {
                    string line = files.ReadLine();
                    string[] data = line.Split(' ');

                    FakeDaoDriver.Add(index++, new Driver
                    { 
                        FistName = data[0],
                        LastName = data[1],
                        MiddleName = data[2],
                    });

                }

                if (FakeDaoDriver.Any())
                {
                    return FakeDaoDriver.Select(x => x.Value);
                }
                return null;
            }
        }
        public Driver GetById(int id)
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                GetAll();
                if (FakeDaoDriver.Any())
                {
                    return FakeDaoDriver.FirstOrDefault(x => x.Key == id).Value;
                }

                return null;
            }
        }

        public void Add(Driver Driver)
        {
            if (Driver == null)
                return;

            GetAll();
            if (FakeDaoDriver == null)
                return;

            using (StreamWriter files = new StreamWriter(_connectionString))
            {
                var lastIndex = FakeDaoDriver.LastOrDefault().Key;
                if (lastIndex == 0)
                    FakeDaoDriver.Add(lastIndex++, Driver);
                else
                    FakeDaoDriver.Add(++lastIndex, Driver);

                foreach (var driver in FakeDaoDriver.Values)
                {
                    files.WriteLine($"{driver.FistName} {driver.MiddleName} {driver.LastName}");
                }
                


            }
        }

        public void DeleteById(int id)
        {
            GetAll();
            if (FakeDaoDriver == null || !FakeDaoDriver.Any())
                return;

            using (StreamWriter files = new StreamWriter(_connectionString, false))
            {
                if (!FakeDaoDriver.Remove(id))
                    return;

                foreach (var Driver in FakeDaoDriver.Values)
                {
                    files.WriteLine($"{Driver.FistName} {Driver.MiddleName} {Driver.LastName}");
                }
            }
        }


        public IEnumerable<Driver> FindByLastName(string lastName)
        {
            GetAll();
            if (FakeDaoDriver == null || !FakeDaoDriver.Any())
                return null;

            return FakeDaoDriver.Where(x => x.Value.LastName == lastName).Select(x => x.Value);
        }

        public void Show() 
        {
            GetAll();
            if (FakeDaoDriver == null || !FakeDaoDriver.Any())
            {
                Console.WriteLine("Водителей нет");
                return;
            }

            foreach (var item in FakeDaoDriver)
            {
                Console.WriteLine($"{item.Key}: {item.Value.LastName} {item.Value.FistName} {item.Value.MiddleName}");
            }
        }
    }
}
