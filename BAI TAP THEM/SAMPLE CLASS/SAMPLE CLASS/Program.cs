using System;

namespace SAMPLE_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            AAnimal whiteTiger = new Tiger(4);
            AAnimal blackHorse = new Horse(4);


            Console.WriteLine(whiteTiger.Move());
            Console.WriteLine(whiteTiger.Speak());

            Console.WriteLine(blackHorse.Move());
            Console.WriteLine(blackHorse.Speak());
        }
    }
}
