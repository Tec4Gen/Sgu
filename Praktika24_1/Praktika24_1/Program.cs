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

                Console.WriteLine("Выберите действие");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("1)Посмотреть товары");
                Console.WriteLine("2)Добавить товар");
                Console.WriteLine("3)Удалить товар");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("4)Посмотреть акции");
                Console.WriteLine("5)Добавить акцию");
                Console.WriteLine("6)Удалить акцию");
                Console.WriteLine(new String('*', 20));
                Console.WriteLine("9)Выйти из программы");

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
                        
                            foreach (var item in all)
                            {
                                Console.WriteLine($"{item.Id} {item.Title} {item.Price}");
                            }
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
                            break;

                        case 4:
                            List<Stock> allAcii = StockLogic.GetAll();
                            if (allAcii.Count == 0)
                            {
                                Console.WriteLine("Акций нет");
                            }
                            
                            foreach (var item in allAcii)
                            {
                                Console.WriteLine($"{item.Id} {item.Title} {item.Description}");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Введите");
                            Console.Write("Название:");
                            string titleStock = Console.ReadLine();
                            Console.Write("Описание акции:");
                            string descriotion = Console.ReadLine();
                            Stock stock = new Stock
                            {
                                Title = titleStock,
                                Description = descriotion,
                            };

                            StockLogic.Add(stock);

                            break;

                        case 6:
                            Console.WriteLine("Введите id:");

                            if (int.TryParse(Console.ReadLine(), out int idS))
                            {
                                StockLogic.DeleteById(idS);
                            }
                            else
                            {
                                Console.WriteLine("Не верное id");
                            }
                            break;
                        case 9:
                            flag = false;
                            message = "Завершение работы";
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(new String('&',20));
                    Console.WriteLine(message);
                    Console.WriteLine(new String('&', 20));

                }

            }
            Console.Read();
        }
            
    }
}
