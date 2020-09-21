using Praktika24_1.Type;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Praktika24_1.Logic
{
    public class ProductLogic
    {
        //Словарик для хранения всех товаров из файла
        private Dictionary<int, Product> SpisokProduct = new Dictionary<int, Product>();

        //Получить в виде листа  List<Product> все товары
        public List<Product> GetAll()
        {
            int count = 0;
            using (StreamReader files = new StreamReader("../../Files/Product.txt", Encoding.GetEncoding(1251)))
            {
                List<Product> Product = new List<Product>();
                SpisokProduct.Clear();
                while (!files.EndOfStream)
                {

                    //Список который будем возвращать

                    string line = files.ReadLine();
                    string[] info = line.Split(' ');

                    // тут просто собираем из каждой линии в файле объект и добавляем его в наш общий словарик 
                    int.TryParse(info[2], out int price);
                    int.TryParse(info[0], out int id);
                    SpisokProduct.Add(count++, new Product
                    {
                        Id = id,
                        Title = info[1],
                        Price = price,
                    });
                }

                foreach (var item in SpisokProduct.Values)
                {
                    Product.Add(item);
                }
                return Product;
            }

        }
        //Добавляем товары 
        public void Add(Product product)
        {
            if (product == null)
                return;

            GetAll();//получаем все - для актцальности данных что бы ничего не потерять
            if (SpisokProduct == null)
                return;

            using (StreamWriter files = new StreamWriter("../../Files/Product.txt", true, Encoding.GetEncoding(1251)))
            {
                int lastIndex = 0;
                //Берем максимальный индекс в нашем списке акций
                if (SpisokProduct.Count() != 0)
                {
                    lastIndex = SpisokProduct.Select(x => x.Key).Max();
                    //Прибавляем +1 от того максимального индекса чтоо получили
                    product.Id = ++lastIndex;//Добавляем id товару
                    SpisokProduct.Add(++lastIndex, product);//Записываем в наш словарик
                                                            //теперь в конец файла кладем нашу запись
                }
                else 
                {
                    SpisokProduct.Add(lastIndex++, product);//Записываем в наш словарик
                }

                files.WriteLine($"{product.Id} {product.Title} {product.Price}");
            }
        }

        public void DeleteById(int id)
        {

            GetAll();//получаем все - для актцальности данных что бы ничего не потерять
            if (SpisokProduct == null) // Проверяем пустой ли список или равный нулл
                return;

            using (StreamWriter files = new StreamWriter("../../Files/Product.txt", false, Encoding.GetEncoding(1251)))
            {
                //флаг проверяет если удалился вернет true если нет false
                bool flag = SpisokProduct.Remove(id);
                //Если не удалилось отменяем операцию
                if (!flag) 
                {
                    foreach (var product in SpisokProduct.Values)
                    {

                        files.WriteLine($"{product.Id} {product.Title} {product.Price}");
                    }
                    return;
                }
                   
                //Производим польную перезапись файла без уже удаленного элемента, за это отвечает флаг false в StreamWriter
                foreach (var product in SpisokProduct.Values)
                {

                    files.WriteLine($"{product.Id} {product.Title} {product.Price}");
                }
                return;
            }
        }

        public List<Product> FindByTitile(string title) 
        {
            GetAll();//получаем все - для актцальности данных что бы ничего не потерять
            if (SpisokProduct == null || SpisokProduct.Count == 0) // Проверяем пустой ли список или равный нулл
                return null;
            return SpisokProduct.Values.Where(x => x.Title == title).Select(x=>x).ToList();
        }
    }
}

