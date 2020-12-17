using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ICOMPARER_SO_SANH_CAC_LOP_HINH_HOC
{
    class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getRadius() > c2.getRadius()) return 1;
            else if (c1.getRadius() < c2.getRadius()) return -1;
            else return 0;
        }
    }
}
