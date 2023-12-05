using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Work
{
    public class Trainee : Employee
    {
        public int WorkingHours { get; set; }   
        public int ShoolHours { get; set; } 

        public Trainee(int workingHours,int schoolHours,string name,string firstName,int salary) :base(name,firstName,salary)
        {
       this.WorkingHours = workingHours;
           this.ShoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Im learning for {0} hours",ShoolHours);
        }

        public void Work()
        {
            Console.WriteLine("Im working {0} hours",WorkingHours);
        }

    }
}
