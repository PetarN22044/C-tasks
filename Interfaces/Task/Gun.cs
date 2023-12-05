using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task
{
    public class Gun : Weapon
    {
        public string GunName { get; set; } 

        public string Model { get; set; }   

        public Gun() { }
        public Gun(string gunName, string model,string firstName,string lastName): base(firstName,lastName)
        {
            this.GunName = gunName;
            this.Model = model;
        }
        public void Shoot(string name)
        {
            Console.WriteLine($"Gun {Model}-{GunName} has {name} voice shoot by {FirstName} - {LastName}");
        }
    }
}
