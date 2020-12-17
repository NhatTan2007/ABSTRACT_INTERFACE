using System;

namespace TRIEN_KHAI_INTERFACE_RESIZEABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            Square newSquare = new Square(23, "red", true);
            Console.WriteLine(newSquare.ToString());

            Rectangle newRectangle = new Rectangle(10, 25, "blue", true);
            Console.WriteLine(newRectangle.ToString());

            Circle newCircle = new Circle(56, "yellow", false);
            Console.WriteLine(newCircle.ToString());

            Console.WriteLine("----------------------------");

            IResizeable[] newShapList = {newSquare, newRectangle, newCircle};
            foreach (var item in newShapList)
            {
                item.Resize(randomNumber.Next(1, 101));
                Console.WriteLine(item.ToString());
            }
        }
    }
}
