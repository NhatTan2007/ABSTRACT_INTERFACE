using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ICOMPARER_SO_SANH_CAC_LOP_HINH_HOC
{
    class RectangleComparator : IComparer<Rectangle>
    {
        public int Compare(Rectangle r1, Rectangle r2)
        {
            if (r1.getLength() > r2.getLength() && r1.getWidth() > r2.getWidth()) return 1;
            else if (r1.getLength() < r2.getLength() && r1.getWidth() < r2.getWidth()) return -1;
            else return 0;
        }
    }
}
