﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }
        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuf!.");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }




    }
}
