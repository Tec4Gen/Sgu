using System;
using System.IO;
using System.Diagnostics;

namespace Example
{
    class Program
    {
        static void Main()
        {
            BinaryTree tree = new BinaryTree();	//инициализируем дерево
            //на основе данных файла создаем дерево
            using (StreamReader fileIn = new StreamReader("../../../input.txt"))
            {
                string line = fileIn.ReadToEnd();
                string[] data = line.Split(' ');
                foreach (string item in data)
                {
                    tree.Add(int.Parse(item));
                }
            }


            //Random rnd = new Random();	//инициализируем генератор случайных чисел
            //int n = rnd.Next(500, 550);	//генерируем случайное число из диапазона [150..200)
            //for (int i = 0; i < n; i++)
            //{
            //    tree.InsertRandom(rnd.Next(int.MaxValue));	// заполняем дерево случайными целыми неотрицательными числами, непривосходящими по значению 100
            //}

            //Console.WriteLine("Дерево до балансировки");
            tree.Preorder();	//используя прямой обход выводим на экран узлы дерева
            Console.WriteLine();

            //подсчитваем вермя балансировки дерева
            Stopwatch sw = new Stopwatch();//инициализируем счетчик времени
            sw.Start();//запускаем счетчик времени
            tree.Balancer();
            sw.Stop();//выключаем счетчик времени

            Console.WriteLine("Дерево после балансировки");
            tree.Preorder();	//используя прямой обход выводим на экран узлы дерева
            Console.WriteLine();
            Console.WriteLine("Балансировка дерева выполняется за {0} миллисекунды", sw.ElapsedTicks);

            //Console.WriteLine("Дерево после самоорганизующего поиска");
            //tree.SearchToRoot(22);
            //tree.Preorder();
            //tree.Preorder();	//используя прямой обход выводим на экран узлы дерева
            Console.WriteLine();

      }
    }
}
