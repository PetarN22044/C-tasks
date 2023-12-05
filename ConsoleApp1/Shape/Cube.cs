using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Shape
{
   public class Cube : Shape
    {
        public double Length { get; set; }
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override double Volume()
        {
             return Math.Pow(Length, 3);// go mnozam po 3 po 3 
            //ili kubik = 3 !
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The cube has {Length}");
        }
    }
}
