using System;

namespace ICOMPAREABLE_CHO_CAC_LOP_HINH_HOC
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareableCircle[] circles = new CompareableCircle[3];
            circles[0] = new CompareableCircle(3.6);
            circles[1] = new CompareableCircle();
            circles[2] = new CompareableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (CompareableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (CompareableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
