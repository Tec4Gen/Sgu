using Praktika24_1.Logic;
using Praktika24_1.Type;
using System;
using System.Collections.Generic;

namespace Praktika24_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag) 
            {
                ProductLogic ProductLogic = new ProductLogic();
                StockLogic StockLogic = new StockLogic();

                Console.WriteLine("=>Выберите действие<=");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("1)Посмотреть товары");
                Console.WriteLine("2)Добавить товар");
                Console.WriteLine("3)Удалить товар");
                Console.WriteLine("4)Найти товар по названию");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("5)Посмотреть акции");
                Console.WriteLine("6)Добавить акцию");
                Console.WriteLine("7)Удалить акцию");
                Console.WriteLine("8)Найти акцию по дане");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("9)Выйти из программы");
                Console.WriteLine();
                string message = "Возврат в меню";

                if (int.TryParse(Console.ReadLine(), out int action))
                {
                    switch (action)
                    {
                        case 1:
                            List<Product> all = ProductLogic.GetAll();
                            if (all.Count == 0)
                            {
                                Console.WriteLine("Товаров нет");
                            }
                            Console.WriteLine("Все товары:");
                            foreach (var item in all)
                            {
                                Console.WriteLine($"{item.Id} {item.Title} {item.Price}");
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Введите");
                            Console.Write("Название:");
                            string title = Console.ReadLine();
                            Console.Write("Цену:");
                            if (!int.TryParse(Console.ReadLine(), out int Price))
                            {
                                Console.WriteLine("неверная цена, возврат в меню");
                                break;
                            }
                            Product product = new Product
                            {
                                Price = Price,
                                Title = title,
                            };

                            ProductLogic.Add(product);

                            Console.WriteLine(new String('!', 20));
                            Console.WriteLine("Продукт добавлен");
                            Console.WriteLine(new String('!', 20));
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine("Введите id:");

                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                ProductLogic.DeleteById(id);
                            }
                            else
                            {
                                Console.WriteLine("Не верное id");
                            }
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Введите название товара:");

                            string titile = Console.ReadLine();

                            var findList = ProductLogic.FindByTitile(titile);
                            if (findList != null)
                            {
                                if (findList.Count == 0) 
                                {
                                    Console.WriteLine("Товаров нет");
                                    Console.WriteLine();
                                    break;
                                }
                                Console.WriteLine("Найденые товары");
                                Console.WriteLine(new String('=', 20));
                                foreach (var item in findList)
                                {
                                    
                                    Console.WriteLine($"{item.Id} {item.Title} {item.Price}");
                                }
                                Console.WriteLine(new String('=', 20));
                            }
                            else 
                            {
                                Console.WriteLine("Товаров с таким названием нет");
                            }
                            Console.WriteLine();
                            break;
                        case 5:
                            List<Stock> allAcii = StockLogic.GetAll();
                            if (allAcii.Count == 0)
                            {
                                Console.WriteLine("Акций нет");
                                break;
                            }
                            Console.WriteLine("Все акции:");
                            foreach (var item in allAcii)
                            {
                                Console.WriteLine($"{item.Id} {item.Title} {item.Date.Date:MM/dd/yyyy}");
                            }
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Введите");
                            Console.Write("Название:");
                            string titleStock = Console.ReadLine();
                            Console.Write("Дату проведения ММ/ДД/ГГГГ:");
                            string dateString = Console.ReadLine();

                            try
                            {
                                DateTime dateAdd = DateTime.ParseExact(dateString, "MM/dd/yyyy", null);
                                Stock stock = new Stock
                                {
                                    Title = titleStock,
                                    Date = dateAdd,
                                };

                                StockLogic.Add(stock);
                                Console.WriteLine(new String('!', 20));
                                Console.WriteLine("Акция добавлена");
                                Console.WriteLine(new String('!', 20));
                                Console.WriteLine();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(new String('!',20));
                                Console.WriteLine("Неверная дата");
                                Console.WriteLine(new String('!', 20));
                                Console.WriteLine();
                                break;
                            }
                            

                        case 7:
                            Console.WriteLine("Введите id:");

                            if (int.TryParse(Console.ReadLine(), out int idS))
                            {
                                StockLogic.DeleteById(idS);
                            }
                            else
                            {
                                Console.WriteLine("Не верное id");
                            }
                            Console.WriteLine();
                            break;

                        case 8:
                            DateTime date;
                            Console.Write("Введите дату ММ/ДД/ГГГГ:");
                            string dateFind = Console.ReadLine();
                            try
                            {
                                date = DateTime.ParseExact(dateFind, "MM/dd/yyyy", null);
                                var listStock = StockLogic.FindByDate(date);
                                if (listStock.Count == 0)
                                {
                                    Console.WriteLine("Акций нет");
                                    Console.WriteLine();
                                    break;
                                }
                                Console.WriteLine("Найденые акции");
                                foreach (var item in listStock)
                                {
                                    Console.WriteLine($"{item.Id} {item.Title} {item.Date.Date:MM/dd/yyyy}");
                                }
                                Console.WriteLine();
                            }
                            catch
                            {
                                Console.WriteLine("Введите нормальную дату: ММ/ДД/ГГГГ");
                            }
                            Console.WriteLine();
                            break;
                        case 9:
                            flag = false;
                            message = "Завершение работы";
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine(new String('!', 20));
                    Console.WriteLine(message);
                    Console.WriteLine(new String('!', 20));

                    Console.WriteLine("Нажмите любую кнопку что бы продолжить");
                    Console.ReadLine();
                }
            }
        }        
    }
}
