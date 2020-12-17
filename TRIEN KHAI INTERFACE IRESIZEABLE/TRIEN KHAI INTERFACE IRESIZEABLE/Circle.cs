using System;
using System.Collections.Generic;
using System.Text;

namespace TRIEN_KHAI_INTERFACE_RESIZEABLE
{
    class Circle : Shape, IResizeable
    {
        private double _radius;

        public double Radius { get => _radius; set => _radius = value; }

        public Circle()
        {
            _radius = 1.0;
        }
        public Circle(double radius) : base()
        {
            _radius = radius;
        }

        public Circle(double radius, string color, bool isFilled) : base(color, isFilled)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double GetPerimeter()
        {
            return Math.PI * 2 * _radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius= {_radius}, which is a subclass of {base.ToString()}"; 
        }

        public void Resize(double percent)
        {
            _radius *= (1 + (double)(percent / 100));
        }
    }
}
