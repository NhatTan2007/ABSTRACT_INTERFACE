using System;
using System.Collections.Generic;

namespace ICOMPARER_SO_SANH_CAC_LOP_HINH_HOC
{
    class Program
    {
        static void Main(string[] args)
        {
            // CircleComparer Test:

            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            // RectangleComparer Test:

            Rectangle[] rectangle = new Rectangle[3];
            rectangle[0] = new Rectangle(3.6, 5.2);
            rectangle[1] = new Rectangle();
            rectangle[2] = new Rectangle(3.5, 6.3, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Rectangle item in rectangle)
            {
                Console.WriteLine(item);
            }

            IComparer<Rectangle> rectangleComparator = new RectangleComparator();
            Array.Sort(rectangle, rectangleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Rectangle item in rectangle)
            {
                Console.WriteLine(item);
            }

            // SquareComparer Test:

            Square[] squares = new Square[3];
            squares[0] = new Square(3.6);
            squares[1] = new Square();
            squares[2] = new Square(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Square item in squares)
            {
                Console.WriteLine(item);
            }

            IComparer<Square> squareComparator = new SquareComparator();
            Array.Sort(squares, squareComparator);

            Console.WriteLine("After-sorted:");
            foreach (Square item in squares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
