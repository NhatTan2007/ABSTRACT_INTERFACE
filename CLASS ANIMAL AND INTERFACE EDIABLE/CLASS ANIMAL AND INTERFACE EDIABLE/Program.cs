using System;

namespace CLASS_ANIMAL_AND_INTERFACE_EDIABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            AAnimal[] animalList = new AAnimal[2];
            animalList[0] = new Chicken();
            animalList[1] = new Tiger();

            foreach (AAnimal item in animalList)
            {
                Console.WriteLine(item.MakeSound());
                if(item is Chicken)
                {
                    Console.WriteLine(((Chicken)item).HowToEat());
                }
            }
        }
    }
}
