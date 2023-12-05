using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Car
    {
        private string _name;// ova e za storing data
        private int _hp;
        private string _color;

        public void setName(string name)
        {
             _name = name;           
        }
        // sega ke imame vtor constructor koj e defolten eve kako
        public Car() {
            // sme naprajle use eden prazen ama ne e prazen zs ne smejt da e null ne imat problem tuka zato
            // na ovie private fields sme im dale nekakva vrednost
            _name = "Car";
            _hp = 0;
            _color = "red"; 

        }
        //Partial Construstor
        public Car(string name,int hp = 0) {
            _name = name;   
            Console.WriteLine( name + " was created");
        _hp = hp;
            _color="Blue";// 
        }
        //Full Construcor
        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
        }

        // znaci imame 3 konstruktori edniot e defolten ,drugiot  imat vrednost samo color koj e Blue po deafult,
        // a tretiot e nekako celosen zoso vo instancata ke mozime nie da davame vrednosti kakvi so sakame
        public void Drive()
        {
            
            Console.WriteLine( _name +" Car is Driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " Car stopper!");
        }
        public void DetailsOfCar()
        {
            Console.WriteLine(_name + " has horse power of " + _hp + "and color is " + _color);
            
        }
    }
}
