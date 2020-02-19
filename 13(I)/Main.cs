using System;
using System.IO;
using Example;
//13 (I) количество узлов, значение которых меньше среднего арифметического;
class Main_
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree(); //инициализируем дерево
                                            //на основе данных файла создаем дерево
        using (StreamReader fileIn = new StreamReader("../../../input.txt"))
        {
            string line = fileIn.ReadToEnd();
            string[] data = line.Split(' ');
            try
            {
                foreach (string item in data)
                {

                    tree.Add(int.Parse(item));
                }
            }
            catch
            {
                Console.WriteLine("Файл пустой");
            }
            
        }
        tree.FindNode(); //используя прямой обход выводим на экран узлы дерева
    }
}