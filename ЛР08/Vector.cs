using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР08
{
    class Vectors
    {
        public static ArrayVector Sum(IVectorable vec1, IVectorable vec2) // сумма векторов
        {
            ArrayVector result = new ArrayVector();
            if (vec1.Length == vec2.Length)
            {
                Console.WriteLine("Сумма векторов: ");
                double sum;
                for (int i = 0; i < vec1.Length; i++)
                {
                    sum = vec1[i] + vec2[i];
                    result[i] = sum;
                    Console.Write(result[i] + " ");
                }
            }
            else
            {
                try
                {
                    throw new FormatException();
                }
                catch
                {
                    Console.WriteLine("Действие невозможно!");
                }
            }
            return result;
        }
        public static double Scalar(IVectorable vec1, IVectorable vec2) // скалярное произведение
        {
            double result = 0;
            if (vec1.Length == vec2.Length)
            {
                Console.WriteLine("Скалярное произведние:");
                for (int i = 0; i < vec1.Length; i++)
                {
                    result += vec1[i] * vec2[i];
                }
            }
            else
            {
                try
                {
                    throw new FormatException();
                }
                catch
                {
                    Console.WriteLine("Действие невозможно!");
                }
            }
            return result;
        }
        public static double GetNorm(IVectorable vec) // длина вектора
        {
            double len = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                len += Math.Pow(vec[i], 2);
            }
            len = Math.Sqrt(len);
            return len;
        }
    }
}
