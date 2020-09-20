using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika24_1.Logic;
using Praktika24_1.Type;

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

                Console.WriteLine("1)Посмотреть товары");
                Console.WriteLine("2)Добавить товар");
                Console.WriteLine("3)Удалить товар");

                Console.WriteLine("4)Посмотреть акции");
                Console.WriteLine("5)Добавить акцию");
                Console.WriteLine("6)Удалить акцию");



                if (int.TryParse(Console.ReadLine(), out int action))
                {
                    switch (action)
                    {
                        case 1:
                            List<Product> all = ProductLogic.GetAll();
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
                        default:
                            break;
                    }

                    Console.WriteLine("Выйти? Да/Нет");
                    string stop = Console.ReadLine();

                    switch (stop)
                    {
                        case "Да":
                            flag = false;
                            break;
                        case "Нет":
                            break;
                        default:
                            Console.WriteLine("Такой команды нет");
                            goto case "Да";
                    }
                }

            }
        }
            
    }
}
