using Praktika24_1.Type;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            using (StreamReader files = new StreamReader("Proruct.txt"))
            {
                List<Product> Product = new List<Product>();

                while (!files.EndOfStream)
                {
                    SpisokProduct.Clear();
                    //Список который будем возвращать

                    string line = files.ReadLine();
                    string[] info = line.Split(' ');

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

            GetAll();
            if (SpisokProduct == null || SpisokProduct.Count() == 0)
                return;

            using (StreamWriter files = new StreamWriter("Proruct.txt", true))
            {
                var lastIndex = SpisokProduct.Select(x => x.Key).Max();
                
                product.Id = ++lastIndex;
                SpisokProduct.Add(++lastIndex, product);

                files.WriteLine($"{product.Id} {product.Title} {product.Price}");
            }
        }

        public void DeleteById(int id)
        {

            GetAll();
            if (SpisokProduct == null || SpisokProduct.Count() == 0)
                return;

            using (StreamWriter files = new StreamWriter("Proruct.txt", false))
            {
                bool flag = SpisokProduct.Remove(id);
                if (!flag)
                    return;

                foreach (var product in SpisokProduct.Values)
                {
                    files.WriteLine($"{product.Id} {product.Title} {product.Price}");
                }
            }
        }
    }
}

