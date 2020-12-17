using System;
using System.Collections.Generic;
using System.Text;

namespace SAMPLE_CLASS
{
    class Horse : AAnimal
    {
        public Horse()
        {

        }
        public Horse(int legs) : base(legs)
        {

        }

        public override string Move()
        {
            return "Horse is moving";
        }

        public override string Speak()
        {
            return "Hi hi hi";
        }
    }
}
