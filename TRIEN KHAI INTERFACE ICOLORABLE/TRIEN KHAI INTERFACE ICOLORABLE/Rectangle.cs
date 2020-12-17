using System;
using System.Collections.Generic;
using System.Text;

namespace TRIEN_KHAI_INTERFACE_ICOLORABLE
{
    class Rectangle : Shape, IResizeable
    {
        private double _width;
        private double _length;

        public double Width { get => _width; set => _width = value; }
        public double Length { get => _length; set => _length = value; }

        public Rectangle()
        {
            _width = _length = 1.0;
        }

        public Rectangle(double width)
        {
            _width = width;
            _length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            _width = width;
            _length = length;
        }

        public Rectangle(double width, double length, string color, bool isFilled) : base(color, isFilled)
        {
            _width = width;
            _length = length;
        }

        public override double GetArea()
        {
            return _width * _length;
        }

        public double GetPerimeter()
        {
            return (_width + _length) * 2;
        }

        public override string ToString()
        {
            return $"A Rectangle with width={_width} and length={_length}, which is a subclass of {base.ToString()}";
        }
        public virtual void Resize(double percent)
        {
            _width *= (1 + (double)(percent / 100));
            _length *= (1 + (double)(percent / 100));
        }

    }
}
