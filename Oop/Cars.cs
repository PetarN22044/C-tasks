using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Cars
    {
        private string _CarName;
        public int _speedCar;
        private string _color;
        public string CarName { get { return _CarName; } set { _CarName = value; } }
        // ovde sme kazale sledno kako i vo racnite metodi
        //vrati mi ime ili carName posle to mu vikat poso e setirano ama so vrednosta od getot ili od privatefield
        // tuka e momentot

        public int SpeedCar { get { 
            return _speedCar;   
            } set { 
            _speedCar = value;  
            } }// ovde e razdeleno a gore e vo edna linija

        public string Color
        {
            get
            {
                return _color;
            }
            set { _color = value; }
        }
        public bool IsRegistered { get; set; }  

        public Cars(string color)
        {
            _color = color;
        }
        public string GetCarName ()
        {
          if (CarName == "")
            {
                CarName = "Deafult";
            }
            else
            {
                return CarName;
            }
            return CarName;
        }

        public void GetCarSpeed (int speed)
        {

            _speedCar = speed;
           
            if (speed == 0)
            {
                Console.WriteLine("Your car is not exist");
            }else if(speed != null)
            {
                Console.WriteLine("speed of car is {0} and your car is {1}",speed,CarName);
            }
        }
        public void GetColor()
        {
            _color = Color;
            Console.WriteLine(Color + "Its your color of your car");

        }

    }
}
