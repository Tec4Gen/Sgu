using System;

namespace Example
{
    public class BinaryTree //класс, реализующий АТД «дерево бинарного поиска со счетчиком вершин в дереве»
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного
        //поиска
        private class Node
        {
            static int MainRoot;
            static int SubRoot;
            static int MinAdd;
            static bool CheckFlag = false;
            public object inf;  //информационное поле
            public int counter;

            public Node left;   //ссылка на левое поддерево
            public Node rigth;  //ссылка на правое поддерево

            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                counter = 1;
                left = null;
                rigth = null;
            }

            //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
            public static void Add(ref Node r, object nodeInf)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    r.counter++;
                    if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                    {
                        Add(ref r.left, nodeInf);
                    }
                    else
                    {
                        Add(ref r.rigth, nodeInf);
                    }
                }
            }
            public static int PutRoot(Node r)
            {
                if (r == null)
                {
                    return 0;
                }
                else
                {
                    SubRoot = (int)r.inf;
                    return 0;
                }
            }
            public static int PutMainRoot(Node r)
            {
                if (r == null)
                {
                    return 0;
                }
                else
                {
                    MainRoot = (int)r.inf;
                    return 0;
                }
            }
            public static void Preorder(Node r) //прямой обход дерева
            {
                if (r != null)
                {
                    if (r.counter <= 2)
                    {
                        if (r.counter == 2 && CheckFlag == true)
                        {
                            MinAdd = (int)r.inf;
                            if (r.left == null)
                            {
                                Console.WriteLine($"Минимальный добавляемый меньше {SubRoot} и меньше {MinAdd}");
                                return;
                            }
                            else if (r.rigth == null)
                            {
                                if ((int)r.inf >= MainRoot)
                                {
                                    Console.WriteLine($"Минимальный добавляемый больше {SubRoot} и больше {MinAdd}");
                                }
                                else 
                                {
                                    Console.WriteLine($"Минимальный добавляемый больше {SubRoot} и больше {MinAdd}, но не превышает корень дерева {MainRoot}");
                                }
                               
                                return;
                            }
                        }
                        else if (r.counter == 1 && CheckFlag == true)
                        {
                            MinAdd = (int)r.inf;
                            if (SubRoot > MinAdd)
                            {
                                Console.WriteLine($"Минимальный добавляемый меньше {MinAdd} и меньше {SubRoot}, но не меньше {MainRoot}");
                            }
                            else
                            {
                                Console.WriteLine($"Минимальный добавляемый больше {SubRoot} и меньше {MinAdd}");
                            }
                            
                           
                            return;
                        }
                        else 
                        {
                            Console.WriteLine("Разница в поддеревьях не привышает 2, оно сбалансированно");
                            return;
                        }
                        
                    }
                    if (r.left != null && r.rigth != null)
                    {
                        if (r.left.counter == r.rigth.counter)
                        {
                            PutRoot(r);
                            Preorder(r.left);
                        }
                        else
                        {
                            if (Math.Abs(r.left.counter - r.rigth.counter) <= 2)
                            {
                                if (Math.Abs(r.left.counter - r.rigth.counter) == 2)
                                {
                                    CheckFlag = true;
                                }
                                if (r.left.counter > r.rigth.counter)
                                {
                                    PutRoot(r);
                                    Preorder(r.rigth);

                                }
                                else
                                {
                                    PutRoot(r);
                                    Preorder(r.left);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Разница в поддеревьях привышает 2, одним элементом не сбалансировать");
                            }
                        }
                    }
                    else if (r.left != null && r.rigth == null)
                    {
                        PutRoot(r);
                        Preorder(r.left);
                    }
                    else
                    {
                        PutRoot(r);
                        Preorder(r.rigth);
                    }
                }
            }

            public static void Inorder(Node r)  //симметричный обход дерева
            {
                if (r != null)
                {
                    Inorder(r.left);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                    Inorder(r.rigth);
                }
            }

            public static void Postorder(Node r)    //обратный обход дерева
            {
                if (r != null)
                {
                    Postorder(r.left);
                    Postorder(r.rigth);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                }
            }
            public static void Part(ref Node t, int k)
            {
                int x = (t.left == null) ? 0 : t.left.counter;
                if (x > k)
                {
                    Part(ref t.left, k);
                    RotationRigth(ref t);
                    //Console.WriteLine("Ротация вправо");
                }
                if (x < k)
                {
                    Part(ref t.rigth, k - x - 1);
                    //Console.WriteLine("Ротация влево");
                    RotationLeft(ref t);
                }
            }



            public static void Balancer(ref Node t)
            {
                if (t == null || t.counter == 1) return;
                Part(ref t, t.counter / 2);
                //Preorder(t);
                //Console.WriteLine();
                Balancer(ref t.left);
                Balancer(ref t.rigth);

            }

            //неявная балансировка дерева бинарного поиска
            public static void InsertRandom(ref Node r, object nodeInf, Random rnd)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    if (rnd.Next() < int.MaxValue / (r.counter + 1))
                    {
                        InsertToRoot(ref r, nodeInf);
                    }
                    else
                    {
                        r.counter++;
                        if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                        {
                            InsertRandom(ref r.left, nodeInf, rnd);
                        }
                        else
                        {
                            InsertRandom(ref r.rigth, nodeInf, rnd);
                        }
                    }
                }
            }

            //поиск ключевого узла в дереве
            public static void Search(Node r, object key, out Node item)
            {
                if (r == null)
                {
                    item = null;
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        item = r;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            Search(r.left, key, out item);
                        }
                        else
                        {
                            Search(r.rigth, key, out item);
                        }
                    }
                }
            }

            //самоорганизующийся поиск ключевого узла в дереве
            public static void SearchToRoot(ref Node r, object key)
            {
                if (r != null)
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            SearchToRoot(ref r.left, key);
                            RotationRigth(ref r);

                        }
                        else
                        {
                            SearchToRoot(ref r.rigth, key);
                            RotationLeft(ref r);
                        }
                    }
                }
            }

            public static void Count(ref Node r)
            {
                r.counter = 1;
                if (r.left != null) r.counter += r.left.counter;
                if (r.rigth != null) r.counter += r.rigth.counter;
            }

            public static void RotationRigth(ref Node t)
            {
                Node x = t.left;
                t.left = x.rigth;
                x.rigth = t;

                Count(ref t);
                Count(ref x);

                t = x;


            }

            public static void RotationLeft(ref Node t)
            {
                Node x = t.rigth;
                t.rigth = x.left;
                x.left = t;

                Count(ref t);
                Count(ref x);

                t = x;


            }

            public static void InsertToRoot(ref Node t, object item)
            {
                if (t == null)
                {
                    t = new Node(item);
                }
                else
                {
                    t.counter++;
                    if (((IComparable)(t.inf)).CompareTo(item) > 0)
                    {
                        InsertToRoot(ref t.left, item);
                        RotationRigth(ref t);
                    }
                    else
                    {
                        InsertToRoot(ref t.rigth, item);
                        RotationLeft(ref t);
                    }
                }
            }

        }        //конец вложенного класса

        Node tree;      //ссылка на корень дерева

        //свойство позволяет получить доступ к значению информационного поля корня дерева
        public object Inf
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        public int Counter
        {
            get { return tree.counter; }

        }


        public BinaryTree() //открытый конструктор
        {
            tree = null;
        }

        private BinaryTree(Node r) //закрытый конструктор
        {
            tree = r;
        }

        public void Add(object nodeInf) //добавление узла в дерево
        {
            Node.Add(ref tree, nodeInf);
        }

        //организация различных способов обхода дерева
        public void Preorder()
        {
            Node.Preorder(tree);
        }

        public void Inorder()
        {
            Node.Inorder(tree);
        }

        public void Postorder()
        {
            Node.Postorder(tree);
        }

        //поиск ключевого узла в дереве
        public BinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BinaryTree t = new BinaryTree(r);
            return t;
        }

        //Самоорганизующийся поиск ключевого узла в дереве
        public void SearchToRoot(object key)
        {
            Node.SearchToRoot(ref tree, key);


        }


        public void InsertToRoot(object item)
        {
            Node.InsertToRoot(ref tree, item);
        }


        public void Balancer()
        {
            Node.Balancer(ref tree);

        }
        public void InsertRandom(object nodeInf)
        {
            Random rnd = new Random();
            Node.InsertRandom(ref tree, nodeInf, rnd);
        }
        public void PutRoot()
        {
            Node.PutRoot(tree);
        }
        public void PutMainRoot()
        {
            Node.PutMainRoot(tree);
        }

    }
}