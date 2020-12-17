using System;
using System.Collections.Generic;
using System.Text;

namespace CLASS_ANIMAL_AND_INTERFACE_EDIABLE
{
    class Chicken : AAnimal, IEdible
    {
        public string HowToEat()
        {
            return "Could be fried";
        }

        internal override string MakeSound()
        {
            return "Chicken: Cucta cuc cuc";
        }
    }
}
