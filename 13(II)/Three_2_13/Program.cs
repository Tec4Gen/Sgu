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
            tree.PutRoot();
            tree.Preorder();
      }
    }
}
