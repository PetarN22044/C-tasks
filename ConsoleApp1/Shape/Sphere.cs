using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Shape
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume( )
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            return volume;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The radius of the sphere is {Radius}");
        }
    }
}
