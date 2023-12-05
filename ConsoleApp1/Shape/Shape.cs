using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Shape
{
    public abstract class Shape
    {
        //abstraktnite klasi ne se instanciraat

        public string Name { get; set; }

        public virtual void GetInfo() 
        {
            Console.WriteLine($"\n This is {Name}");
        }
        public abstract double Volume();//ova e nesto kako
        //interface,ako sakam da ja primenam nekade ovaa metoda
        // ke ja definiram na druga klasa,ama koga ke ja nasledam
        // klasata vo toj slucaj ne mi javuva greska kako kaj INterfaces
        // tgaka sto ke moram sam da vidam za koja metoda stanuva zbor
    }
}
