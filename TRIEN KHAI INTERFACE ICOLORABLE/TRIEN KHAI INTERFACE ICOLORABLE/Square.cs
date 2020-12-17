using System;
using System.Collections.Generic;
using System.Text;

namespace TRIEN_KHAI_INTERFACE_ICOLORABLE
{
    class Square : Rectangle, IResizeable, IColorable
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

        public override double GetArea()
        {
            return _side * _side;
        }

        public override string ToString()
        {
            return $"A Square with side= {_side}, which is a subclass of {base.ToString()}";
        }

        public override void Resize(double percent)
        {
            _side *= (1 + (double)(percent / 100));
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides..");
        }
    }
}
