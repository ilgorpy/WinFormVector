using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР08
{
    class LinkedListVector : IVectorable, IComparable, ICloneable
    {
        public Node start;
        public class Node
        {
            private Node next;
            private double value;
            public Node() // конструктор по умолчанию
            {
                next = null;
                value = 0;
            }
            public Node Next // свойство
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public double Value // свойство
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                }
            }

        }
        public int Length // свойство для чтения числа координат
        {
            get
            {
                int n = 0;
                Node node = start;
                while (node != null)
                {
                    node = node.Next;
                    n++;
                }
                return n;
            }
        }
        public LinkedListVector(int len) // конструктор с параметром - длиной списка
        {
            if (len == 0)
            {
                throw new Exception();
            }
            else
            {
                start = new Node();
                Node node = start;
                for (int i = 1; i < len; i++)
                {
                    node.Next = new Node();
                    node = node.Next;
                }
            }
        }
        public LinkedListVector() : this(5) { } // конструктор без параметров, задающий длину списка 5

        public Node GetNode(int index) // узел 
        {
            Node node = start;
            if ((index < Length) && (index > -1))
            {
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            return node;
        }
        public double this[int index] // индексатор для организации доступа к элементам массива
        {
            get
            {
                try
                {
                    return GetNode(index).Value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели некорректный индекс");
                    return 0;
                }
            }
            set
            {
                try
                {
                    GetNode(index).Value = value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели некорректный индекс");
                }
            }
        }
        public double GetNorm() // метод получения длины вектора
        {
            double modul = 0;
            Node node = start;
            while (node != null)
            {
                modul += Math.Pow(node.Value, 2);
                node = node.Next;
            }
            modul = Math.Sqrt(modul);
            return modul;
        }
        public override string ToString() // переопределение метода ToString() 
        {
            string v = Length + " ";
            Node node = start;
            while (node != null)
            {
                v += node.Value + " ";
                node = node.Next;
            }
            return v;
        }
        public override bool Equals(object obj) // переопределение метода Equals()
        {
            if (obj is IVectorable vectorable)
            {
                if (vectorable.Length == Length)
                {
                    int count = 0;
                    for (int i = 0; i < Length; i++)
                    {
                        if (vectorable[i] == GetNode(i).Value)
                            count += 1;
                    }
                    if (Length == count)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(object obj) // метод, сравнивающий векторы по числу их координат
        {
            if (obj is IVectorable vectorable)
            {
                if (Length == vectorable.Length)
                    return 0;
                else if (Length > vectorable.Length)
                    return -1;
                else
                    return 1;
            }
            else
            {
                throw new Exception("Не сравнить!");
            }
        }
        public object Clone() // метод, выполняющий глубокое клонирование объектов
        {
            LinkedListVector res = new LinkedListVector(Length);
            for (int i = 0; i < Length; i++)
            {
                res[i] = this[i];
            }
            return res;
        }
    }
}
