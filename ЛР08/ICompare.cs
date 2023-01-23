using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР08
{
    class ICompare : IComparer<IVectorable>
    {
        public int Compare(IVectorable v1, IVectorable v2) // метод, сравнивающий свои векторы по их модулю
        {
            if (v1.GetNorm() == v2.GetNorm())
                return 0;
            else if (v1.GetNorm() > v2.GetNorm())
                return 1;
            else
                return -1;
        }
    }
}
