﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ANIMAL_MANAGEMENT_SYSTEM
{
    class Crocodile: Animal, ITerrestrialAnimal, IMarineAnimal
    {
        private int _id;
        private string _name;
        private int _age;
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Crocodile()
        {

        }

        public Crocodile(string name, int age) : base()
        {
            _id = Animal.idOfAnimal;
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return $"Animal Type:\t {GetType().Name}\n" +
                $"Animal ID:\t {_id}\n" +
                $"Name:\t\t {_name}\n" +
                $"Age:\t\t {_age}\n";
        }
        void ITerrestrialAnimal.Move()
        {
            Console.WriteLine("Run");
        }

        void IMarineAnimal.Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
