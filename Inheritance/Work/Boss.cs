using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Work
{
    public class Boss :Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName,int salary) : base(name, firstName,salary)
        {
            this.CompanyCar = companyCar;
            
        }
        public void Lead()
        {
            Console.WriteLine("Im  Boss {0} {1}",Name,FirstName);
        }
       
       
    }
}
