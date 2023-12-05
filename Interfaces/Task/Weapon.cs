using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task
{
    public class Weapon : IShootable
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public Weapon()
        {
            
        }
        public Weapon(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public  void Shoot(string name)
        {
            Console.WriteLine("The name of weapon is {0} and the shooter is {1} - {2}",name,FirstName,LastName);
        }
    }
}
