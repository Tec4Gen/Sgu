using System;
using TaxiManager.BLL;
namespace TaxiManager.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var _driverLogic = new DriverLogic();
            var _carLogic = new CarLogic();
            var _workItemLogic = new WorkItemLogic();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1) Посмотреть всех воителей");
                Console.WriteLine("2) Добавить водителя");
                Console.WriteLine("3) Удалить водителя");

                Console.WriteLine("4) Посмотреть все автомобили");
                Console.WriteLine("5) Добавить автомобиль");
                Console.WriteLine("6) Удалить автомобиль");

                Console.WriteLine("7) Посмотреть расписание");
                Console.WriteLine("8) Добавить в расписание");
                Console.WriteLine("9) Удалить из раписания");
                Console.WriteLine("10) Посмотреть на определенную дату");
                Console.WriteLine("11) Посмотреть на промежуток дат");
                Console.WriteLine();
                Console.Write("Выберите действие => ");

                int.TryParse(Console.ReadLine(), out int action);

                switch (action)
                {
                    case 1:
                        _driverLogic.Show();
                        break;
                    case 2:
                        Console.WriteLine("Введите");
                        Console.Write("Имя:");
                        string lastName = Console.ReadLine();
                        Console.Write("Фамилию:");
                        string firstName = Console.ReadLine();
                        Console.Write("Отчество:");
                        string middleName = Console.ReadLine();

                        _driverLogic.Add(new Entities.Driver
                        {
                            FistName = firstName,
                            LastName = lastName,
                            MiddleName = middleName,
                        });

                        break;
                    case 3:
                        Console.WriteLine("Введите id:");

                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            _driverLogic.DeleteById(id);
                        }
                        else 
                        {
                            Console.WriteLine("не число попробуйте снова");
                        }
                        break;
                    case 4:
                        _carLogic.Show();
                        break;

                    case 5:
                        Console.WriteLine("Введите");
                        Console.Write("Марку:");
                        string mark = Console.ReadLine();
                        Console.Write("Модель:");
                        string model = Console.ReadLine();


                        _carLogic.Add(new Entities.Car
                        {
                            Mark = mark,
                            Model = model,
                        });
                        break;
                    case 6:
                        Console.WriteLine("Введите id:");

                        if (int.TryParse(Console.ReadLine(), out int idCar))
                        {
                            _carLogic.DeleteById(idCar);
                        }
                        else
                        {
                            Console.WriteLine("не число попробуйте снова");
                        }
                        break;
                    default:
                        break;

                    case 7:
                        _workItemLogic.Show();
                        break;
                    case 8:
                        Console.WriteLine("Введите");
                        Console.Write("Дату в формате mm/dd/yyyy:");
                        string date = Console.ReadLine();
                        Console.Write("Введите id водителя и id машины:");
                        if (int.TryParse(Console.ReadLine(), out int personeId) && int.TryParse(Console.ReadLine(), out int carId))
                        {
                            var persone = _driverLogic.GetById(personeId);
                            var car = _carLogic.GetById(carId);
                            DateTime datePasre;
                            if (car == null)
                            {
                                Console.WriteLine("Такой машины нет");
                                break;
                            }
                            if (persone == null)
                            {
                                Console.WriteLine("Такого водителя нет");
                                break;
                            }
                            try
                            {
                                datePasre = DateTime.ParseExact(date, "MM/dd/yyyy", null);
                                _workItemLogic.Add(new Entities.WorkItem
                                {
                                    Car = car,
                                    Driver = persone,
                                    WorkDate = datePasre
                                });
                            }
                            catch
                            {
                                Console.WriteLine("Введите нормальную дату!!!");
                                break;
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("Введите id:");

                        if (int.TryParse(Console.ReadLine(), out int idWorkItem))
                        {
                            _workItemLogic.DeleteById(idWorkItem);
                        }
                        break;
                    case 10:
                        Console.WriteLine("Введите дату :");
                        DateTime datePasreFind;
                        Console.Write("Дату в формате mm/dd/yyyy:");
                        string dateFind = Console.ReadLine();  
                        try
                        {
                            datePasreFind = DateTime.ParseExact(dateFind, "MM/dd/yyyy", null);
                            var items1 = _workItemLogic.GetByDate(datePasreFind);

                            Console.WriteLine($"расписание на {datePasreFind.Date}");
                            foreach (var item in items1)
                            {
                                Console.WriteLine($" {item.WorkDate.Date:MM/dd/yyyy} " +
                                    $"{item.Driver.LastName} {item.Driver.FistName} {item.Driver.MiddleName} " +
                                    $"{item.Car.Mark} {item.Car.Model}");
                            }
                        }
                        catch
                        {

                            throw;
                        }
                      
                        break;

                    case 11:
                        Console.WriteLine("Введите дату :");
                        DateTime datePasreFirst;
                        DateTime datePasreSecond;
                        Console.Write("Первая дата в формате mm/dd/yyyy:");
                        string dateFirst = Console.ReadLine();
                        Console.Write("вторая дата в формате mm/dd/yyyy:");
                        string dateSecond = Console.ReadLine();
                        try
                        {
                            datePasreFirst = DateTime.ParseExact(dateFirst, "MM/dd/yyyy", null);
                            datePasreSecond = DateTime.ParseExact(dateSecond, "MM/dd/yyyy", null);
                            var items = _workItemLogic.GetByDateInterval(datePasreFirst, datePasreSecond);

                            Console.WriteLine($"расписание на {datePasreFirst.Date:MM/dd/yyyy} по {datePasreSecond.Date:MM/dd/yyyy}");

                            foreach (var item in items)
                            {
                                Console.WriteLine($" {item.WorkDate.Date:MM/dd/yyyy} " +
                                 $"{item.Driver.LastName} {item.Driver.FistName} {item.Driver.MiddleName} " +
                                 $"{item.Car.Mark} {item.Car.Model}");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Введите нормальную дату!!!");
                            break;
                        }
                        break;
                }

                Console.WriteLine("Выйти из приложения? Y/N");
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "Y":
                        flag = false;
                        break;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Не подходит, повторите");
                        goto case "Y";
                }

            }
            
            Console.ReadLine();
        }
    }
}
