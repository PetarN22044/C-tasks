using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Car
{
    public class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW()
        {
            
        }
        public BMW(int hp,string color,string model):base(hp,color)
        {           
            this.Model = model;      
        }

        public void ShowDetails()
        {
            Console.WriteLine($" Brand:{brand},Model:{Model}  HP: {HP} and the Color is : {Color}");

        }
        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired",Model);
        }



    }
}
