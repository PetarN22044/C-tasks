using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Work
{
    public class Employee
    {
        public string Name { get; set; }    

        public string FirstName { get; set; }   

        public int Salary { get; set; } 

        public Employee() {
            Name = "Petar";
            FirstName = "Petar";
            Salary = 5000;
        }
        public Employee(string name,string firstName,int salary)
        {
           this.Name = name;
           this.FirstName = firstName;
           this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Im working");
        }
        public void Stop()
        {
            Console.WriteLine("Im having a break");
        }
        public override string ToString()
        {
            return String.Format("{0}-{1}-{2}",this.Name,this.FirstName,this.Salary);
        }
    }
}
