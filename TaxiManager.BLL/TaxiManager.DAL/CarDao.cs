using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TaxiManager.Entities;

namespace TaxiManager.DAL
{
    public class CarDao
    {
        private string _connectionString = "CarInfo.txt";

        private Dictionary<int, Car> FakeDaoCar;
        public IEnumerable<Car> GetAll() 
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                FakeDaoCar = new Dictionary<int, Car>();
                int index = 0;
                while (!files.EndOfStream)
                {
                    
                    string line = files.ReadLine();
                    string[] data = line.Split(' ');

                    int.TryParse(data[0], out int id);
                    FakeDaoCar.Add(index, new Car
                    {
                        Id = id,
                        Mark = data[1],
                    });
                    index++;
                }

                if (FakeDaoCar.Any()) 
                {
                    return FakeDaoCar.Select(x => x.Value);
                }
                return null;
            } 
        }
        public Car GetById(int id)
        {
            using (StreamReader files = new StreamReader(_connectionString))
            {
                GetAll();
                if (FakeDaoCar.Any()) 
                {
                   return FakeDaoCar.FirstOrDefault(x => x.Key == id).Value;
                }

                return null;
            }
        }

        public void Add(Car car) 
        {
            if (car == null)
                return;

            GetAll(); 
            if (FakeDaoCar == null)
                return;

            using (StreamWriter files = new StreamWriter(_connectionString))
            {
                var lastIndex = FakeDaoCar.LastOrDefault().Key;
                if (lastIndex == 0)
                {
                    if (FakeDaoCar.Count == 1)
                    {
                        car.Id = lastIndex;
                        FakeDaoCar.Add(++lastIndex, car);
                    }
                    else 
                    {
                        car.Id = lastIndex;
                        FakeDaoCar.Add(lastIndex++, car);
                    }
                   
                }
                else
                {
                    FakeDaoCar.Add(++lastIndex, car);
                    car.Id = lastIndex;
                }
                files.WriteLine($"{car.Id} {car.Mark}");
            }   
        }

        public void DeleteById(int id)
        {
            
            GetAll();
            if (FakeDaoCar == null || !FakeDaoCar.Any())
                return;

            using (StreamWriter files = new StreamWriter(_connectionString, false))
            {
                if (!FakeDaoCar.Remove(id))
                    return;

                foreach (var car in FakeDaoCar.Values)
                {
                    files.WriteLine($"{car.Id} {car.Mark}");
                }
            }
        }
        public void Show()
        {
            GetAll();
            if (FakeDaoCar == null || !FakeDaoCar.Any())
            {
                Console.WriteLine("Машин нет");
                return;
            }

            foreach (var item in FakeDaoCar)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Mark}");
            }
        }

        public IEnumerable<Car> FindByMark(string mark)
        {

            GetAll();
            if (FakeDaoCar == null || !FakeDaoCar.Any())
                return null;

            return FakeDaoCar.Where(x => x.Value.Mark == mark).Select(x => x.Value);
        }
    }
}
