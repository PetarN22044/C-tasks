using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class OhterClass
    {
        private int _age;
        private string _name;
        private string _lastName;
        public OhterClass()
        {
            Console.WriteLine("Another Constructor is maked");
            OhterMethod();
        }

        private void OhterMethod()
            //sme naprajle private void nekakov so data za private info za petar i se ostalo
            // kako nego sega ili od ova da napravime instanca pa taka so sve ke piknime vo konstruktorot
            // koj ke e bez fields zoso nemat potreba poso to ni e definirano vo metodot
        {
            Console.WriteLine("Other Method");
            Console.WriteLine(_age = 29);
            Console.WriteLine(_name = "Petar");
            Console.WriteLine(_lastName = "Nikoloski"); 

        }
    }
}
