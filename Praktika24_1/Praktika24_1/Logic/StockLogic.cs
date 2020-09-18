using Praktika24_1.Type;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Praktika24_1.Logic
{
    public class StockLogic
    {
        //Словарик для хранения всех акций из файла
        private Dictionary<int, Stock> SpisokStock = new Dictionary<int, Stock>();

        //Получить в виде листа  List<Stock> все акции
        public List<Stock> GetAll()
        {
            int count = 0;
            using (StreamReader files = new StreamReader("Stock.txt"))
            {
                List<Stock> Stock = new List<Stock>();

                while (!files.EndOfStream)
                {
                    SpisokStock.Clear();
                    //Список который будем возвращать

                    string line = files.ReadLine();
                    string[] info = line.Split(' ');
                    // тут просто собираем из каждой линии в файле объект и добавляем его в наш общий словарик 
                    int.TryParse(info[0], out int id);
                    SpisokStock.Add(count++, new Stock
                    {
                        Id = id,
                        Title = info[1],
                        Description = info[2],
                    });
                }

                foreach (var item in SpisokStock.Values)
                {
                    Stock.Add(item);
                }
                return Stock;
            }

        }
        //Добавляем товары 
        public void Add(Stock Stock)
        {
            if (Stock == null)
                return;

            GetAll();//получаем все - для актцальности данных что бы ничего не потерять
            if (SpisokStock == null || SpisokStock.Count() == 0)
                return;

            using (StreamWriter files = new StreamWriter("Proruct.txt", true))
            {
                //Берем максимальный индекс в нашем списке акций
                int lastIndex = SpisokStock.Select(x => x.Key).Max();

                //Прибавляем +1 от того максимального индекса чтоо получили
                Stock.Id = ++lastIndex;//Добавляем id товару
                SpisokStock.Add(++lastIndex, Stock);//Записываем в наш словарик

                //теперь в конец файла кладем нашу запись
                files.WriteLine($"{Stock.Id} {Stock.Title} {Stock.Description}");
            }
        }

        public void DeleteById(int id)
        {

            GetAll();//получаем все - для актцальности данных что бы ничего не потерять
            if (SpisokStock == null || SpisokStock.Count() == 0)// Проверяем пустой ли список или равный нулл
                return;

            using (StreamWriter files = new StreamWriter("Proruct.txt", false))
            {
                //флаг проверяет если удалился вернет true если нет false
                bool flag = SpisokStock.Remove(id);
                //Если не удалилось отменяем операцию
                if (!flag)
                    return;
                //Производим польную перезапись файла без уже удаленного элемента, за это отвечает флаг false в StreamWriter
                foreach (var Stock in SpisokStock.Values)
                {
                    files.WriteLine($"{Stock.Id} {Stock.Title} {Stock.Description}");
                }
            }
        }
    }
}
