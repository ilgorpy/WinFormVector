using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР08
{
    interface IVectorable : IComparable, ICloneable
    {
        double this[int i] { get; set; } // индексатор для организации доступа к элементам массива
        int Length { get; } // свойство для чтения числа координат вектора
        double GetNorm(); // метод получения модуля вектора
    }
}
