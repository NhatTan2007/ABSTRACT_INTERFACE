using System;

namespace TRIEN_KHAI_INTERFACE_ICOLORABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRectangle = new Rectangle(10, 23);
            Circle newCircle = new Circle(15);
            Square newSquare = new Square(52);
            Shape[] shapeList = {newRectangle, newCircle, newSquare};

            foreach (Shape item in shapeList)
            {
                Console.WriteLine(item.GetArea());
                if (item.GetType().Name == "Square") ((Square)item).HowToColor();
                
            }
        }
    }
}
