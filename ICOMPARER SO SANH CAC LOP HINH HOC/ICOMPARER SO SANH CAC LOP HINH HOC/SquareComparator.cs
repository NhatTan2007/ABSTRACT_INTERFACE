using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ICOMPARER_SO_SANH_CAC_LOP_HINH_HOC
{
    class SquareComparator : IComparer<Square>
    {
        public int Compare(Square sq1, Square sq2)
        {
            if (sq1.getSide() > sq2.getSide()) return 1;
            else if (sq1.getSide() < sq2.getSide()) return -1;
            else return 0;
        }
    }
}
