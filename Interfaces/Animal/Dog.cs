using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Animal
{
    public class Dog
    {
        public string Name { get; set; }

        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;

        }
        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog: {0} said waff {1} times!.", Name, numberOfTreats);
        }
    }
}
