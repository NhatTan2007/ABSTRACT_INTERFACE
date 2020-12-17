using System;
using System.Collections.Generic;
using System.Text;

namespace ANIMAL_MANAGEMENT_SYSTEM
{
    interface IAnimal
    {
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
