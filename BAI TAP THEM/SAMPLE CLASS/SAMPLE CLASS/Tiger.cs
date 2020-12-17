using System;
using System.Collections.Generic;
using System.Text;

namespace SAMPLE_CLASS
{
    class Tiger : AAnimal
    {
        public Tiger()
        {

        }
        public Tiger(int legs) : base(legs)
        {

        }

        public override string Move()
        {
            return "Tiger is moving";
        }

        public override string Speak()
        {
            return "Grao grao";
        }
    }
}
