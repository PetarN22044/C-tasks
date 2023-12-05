using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Animal
{
    public class DogSelter : IEnumerable<Dog>   
    {
        public List<Dog> dogs;

        public DogSelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Bela",false),
                new Dog("Max",true),
                new Dog ("Orep",false),
                new Dog("Boxel",false)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
