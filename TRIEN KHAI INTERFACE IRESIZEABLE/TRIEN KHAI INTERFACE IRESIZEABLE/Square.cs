using System;
using System.Collections.Generic;
using System.Text;

namespace TRIEN_KHAI_INTERFACE_RESIZEABLE
{
    class Square : Rectangle, IResizeable
    {
        private double _side;

        public double Side { get => _side; set => _side = value; }

        public Square()
        {
            _side = 1.0;
        }

        public Square(double side)
        {
            _side = side;
        }

        public Square(double side, string color, bool isFilled) : base(side, side, color, isFilled)
        {
            _side = side;
        }

        public override string ToString()
        {
            return $"A Square with side= {_side}, which is a subclass of {base.ToString()}";
        }

        public override void Resize(double percent)
        {
            _side *= (1 + (double)(percent / 100));
        }
    }
}
