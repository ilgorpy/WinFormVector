using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР08
{
    class ArrayVector : IVectorable, IComparable, ICloneable
    {
        public double[] arr; // поле - массив эелементов

        public ArrayVector(int len) // конструктор с параметром
        {
            arr = new double[len];
        }
        public ArrayVector() // конструктор без параметров
        {
            arr = new double[5];
        }
        public double this[int i] // индексатор для организации доступа к элементам массива
        {
            get
            {
                try
                {
                    return arr[i];
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
                    arr[i] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели некорректный индекс");
                }
            }
        }
        public double GetNorm() // метод получения длины вектора
        {
            double length = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                length += Math.Pow(arr[i], 2);
            }
            length = Math.Sqrt(length);
            return length;
        }
        public int Length // свойство для чтения числа координат вектора
        {
            get
            {
                return arr.Length;
            }
        }       
        public override string ToString() // переопределение метода ToString() 
        {
            string v = Length + " ";
            for (int i = 0; i < Length; i++)
            {                                
                v += arr[i] + " ";               
            }
            return v;
        }
        public override bool Equals(object obj) // переопределение метода Equals()
        {
            if (obj is IVectorable vectorable)
            {
                if (vectorable.Length == arr.Length)
                {
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (vectorable[i] == arr[i])
                            count += 1;
                    }
                    if (arr.Length == count)
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
            ArrayVector res = new ArrayVector(Length);
            for (int i = 0; i < Length; i++)
            {
                res[i] = this[i];
            }
            return res;
        }
    }
}

