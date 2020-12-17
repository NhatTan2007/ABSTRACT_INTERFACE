using System;
using System.Collections.Generic;
using System.Text;

namespace SAMPLE_CLASS
{
    abstract class AAnimal
    {
        private int _legs;
        public int Legs { get => _legs; set => _legs = value; }

        public AAnimal()
        {

        }

        public AAnimal(int legs)
        {
            _legs = legs;
        }

        public abstract string Move();

        public abstract string Speak();
    }
}
