using System;
using System.Collections.Generic;
using System.Text;

namespace TRIEN_KHAI_INTERFACE_RESIZEABLE
{
    class Shape
    {
        private string _color;
        private bool _filled = false;

        public string Color { get => _color; set => _color = value; }
        public bool Filled { get => _filled; set => _filled = value; }

        public Shape()
        {
            _color = "green";
            _filled = true;
        }

        public Shape(string color, bool isFilled)
        {
            _color = color;
            _filled = isFilled;
        }

        public override string ToString()
        {
            return $"A Shape with color of {_color} and {_filled}";
        }
    }
}
