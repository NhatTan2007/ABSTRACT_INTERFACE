using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ICOMPAREABLE_CHO_CAC_LOP_HINH_HOC
{
    class CompareableCircle : Circle, IComparable<CompareableCircle>
    {

        public CompareableCircle()
        {

        }

        public CompareableCircle(double radius) : base(radius)
        {

        }

        public CompareableCircle(double radius, string color, bool filled) : base(radius, color, filled)
        {

        }
        public int CompareTo(CompareableCircle newObject)
        {
            if (getRadius() > newObject.getRadius()) return 1;
            else if (getRadius() > newObject.getRadius()) return -1;
            else return 1;
        }
    }
}
